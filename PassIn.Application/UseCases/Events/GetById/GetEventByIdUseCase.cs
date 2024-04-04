using Microsoft.EntityFrameworkCore;
using PassIn.Communication.Responses;
using PassIn.Exceptions;
using PassIn.Infrastructure;


namespace PassIn.Application.UseCases.Events.GetById
{
    public class GetEventByIdUseCase
    {
        public ResponseEventJson Execute(Guid id)
        {
            // chama o db context
            var dbContext = new PassInDbContext();
            //pelo id ser primary key, o find funciona corretamente.
            var entity = dbContext.Events.Include(ev => ev.Attendees).FirstOrDefault(ev => ev.Id == id);
            //outra maneira, caso não seja(melhor para operações mais complexas): dbContext.Events.FirstOrDefault(ev => ev.Id == id);
            // se a entidade for nula, não encontrará
            if (entity == null)
                throw new NotFoundException("An event with this ID don't exist");

            //se não for nula, retorna as response events trazendo o id,title,details, maximumattendees e attendeesamount(não implementado ainda)
            return new ResponseEventJson
            {
                Id = entity.Id,
                Title = entity.Title,
                Details = entity.Details,
                MaximumAttendees = entity.Maximum_Attendees,
                AttendeesAmount = entity.Attendees.Count(),
            };


        }
    }
}
