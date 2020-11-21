using MediatR;

namespace Server.Math
{
    public abstract class MathHandler<TRequest> : RequestHandler<TRequest, int> where TRequest : IRequest<int>
    {
        protected readonly IMathService _mathService;
        //---------------------------------------------------------------------
        protected MathHandler(IMathService mathService) => _mathService = mathService;
    }
}
