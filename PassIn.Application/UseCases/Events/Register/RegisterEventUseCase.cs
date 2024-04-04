using PassIn.Communication.Requests;
using PassIn.Communication.Responses;
using PassIn.Exceptions;
using PassIn.Infrastructure;

namespace PassIn.Application.UseCases.Events.Register
{
    //minha regra de negócio, executando a request e validando, trazendo as exceções/mensagens de erro respectivas da estrutura da request,
    //formada por titulo, descrição e total de participantes possíveis
    public class RegisterAttendeetUseCase
    {
        public ResponseRegisteredJson Execute(RequestEventJson request)
        {
            Validate(request);
            var dbContext = new PassInDbContext();

            var entity = new Infrastructure.Entities.Event
            {
                Title = request.Title,
                Details = request.Details,
                Maximum_Attendees = request.MaximumAttendees, 
                Slug = request.Title.ToLower().Replace(" ","-"),
            };
            dbContext.Events.Add(entity);
            dbContext.SaveChanges();

            return new ResponseRegisteredJson
            {
                Id=entity.Id,
            };
        }
        private void Validate(RequestEventJson request)
        {
            if (request.MaximumAttendees <= 0)
            {
                throw new ErrorOnValidationException("The Maximum attendees is invalid.");
            }
            if (string.IsNullOrWhiteSpace(request.Title))
            {
                throw new ErrorOnValidationException("The title is invalid.");
            }
            if (string.IsNullOrWhiteSpace(request.Details))
            {
                throw new ErrorOnValidationException("The details are invalid.");
            }
        }
    }
}
