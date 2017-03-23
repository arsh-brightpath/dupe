using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace project56.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=project56; Trusted_Connection=True;");
            csb["Database"].ShouldBe("project56");
        }
    }
}
