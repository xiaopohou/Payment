using System.IO;

using Essensoft.AspNetCore.Security.Utilities.IO;

namespace Essensoft.AspNetCore.Security.Bcpg.OpenPgp
{
	public class WrappedGeneratorStream
		: FilterStream
	{
		private readonly IStreamGenerator gen;

		public WrappedGeneratorStream(
			IStreamGenerator	gen,
			Stream				str)
			: base(str)
		{
			this.gen = gen;
		}

#if PORTABLE
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                gen.Close();
                return;
            }
            base.Dispose(disposing);
        }
#else
		public override void Close()
		{
			gen.Close();
		}
#endif
	}
}