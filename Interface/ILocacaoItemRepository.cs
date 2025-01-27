﻿using Locadora.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Locadora.Interface
{
	public interface ILocacaoItemRepository : IRepository<LocacaoItem>
	{
		List<LocacaoItem> BuscarPorIdLocacao(int id);
	}
}
