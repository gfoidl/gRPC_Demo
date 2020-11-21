namespace Server.Math
{
    // Only sequential, so use base class instead of interface IRequestHandler<TRequest, TResponse>
    // https://github.com/jbogard/MediatR/wiki#request-types
    public class AddHandler : MathHandler<AddOperation>
    {
        public AddHandler(IMathService mathService) : base(mathService) { }
        //---------------------------------------------------------------------
        protected override int Handle(AddOperation request) => _mathService.Add(request.A, request.B);
    }
}
