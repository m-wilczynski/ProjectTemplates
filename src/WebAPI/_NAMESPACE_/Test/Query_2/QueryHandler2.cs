using _NAMESPACE_.Shared.Contracts.Responses;
using _NAMESPACE_.Shared.Infrastructure.Handlers;
using Test.Query_1;

namespace Test.Query_2
{
    //Should be forbidden for QueryResponse1 to be returned from more than one QueryHandler
    //See: Test.Convention.UnitTests
    public class QueryHandler2 : IQueryHandler<Query2, QueryResponse1>
    {
        public OperationResult<Query2, QueryResponse1> Handle(Query2 query)
        {
            throw new System.NotImplementedException();
        }
    }
}
