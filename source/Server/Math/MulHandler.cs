namespace Server.Math
{
    // Only sequential, so use base class instead of interface IRequestHandler<TRequest, TResponse>
    // https://github.com/jbogard/MediatR/wiki#request-types
    public class MulHandler : MathHandler<MulOperation>
    {
        public MulHandler(IMathService mathService) : base(mathService) { }
        //---------------------------------------------------------------------
        protected override int Handle(MulOperation request) => _mathService.Mul(request.A, request.B);
    }
}
