using CalcularSueldo.DAL.Context;

namespace CalcularSueldo.DAL.Repository
{
    public class TestRepo
    {
        private readonly MyContext context;

        internal TestRepo(MyContext context)
        {
            this.context = context;
        }
    }
}
