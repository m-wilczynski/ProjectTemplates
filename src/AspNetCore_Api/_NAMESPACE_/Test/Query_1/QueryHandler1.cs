using _NAMESPACE_.Shared.Contracts.Responses;
using _NAMESPACE_.Shared.Infrastructure.Handlers;

namespace Test.Query_1
{
    public class QueryHandler1 : IQueryHandler<Query1, QueryResponse1>
    {
        public OperationResult<Query1, QueryResponse1> Handle(Query1 query)
        {
            throw new System.NotImplementedException();
        }
    }
}
