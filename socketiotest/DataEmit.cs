using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socketiotest
{
    class DataEmit
    {

		private int rele_no;

		public int Rele_no
		{
			get { return rele_no; }
			set { rele_no = value; }
		}

		private int cas_jede;

		public int Cas_jede
		{
			get { return cas_jede; }
			set { cas_jede = value; }
		}

		private int cas_priprava;

		public int Cas_priprava
		{
			get { return cas_priprava; }
			set { cas_priprava = value; }
		}


		public override string ToString() 
		{
			return $"rele_no: {rele_no}, cas priprava: {cas_priprava}, cas_jede: {cas_jede}";
		}


	}
}
