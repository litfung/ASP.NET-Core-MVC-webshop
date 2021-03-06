﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MShop.DataLayer.Repositories;

namespace MShop.Presentation.MPA.Public.Components
{
    public class ShippingDetailsViewComponent : ViewComponent
	{
		private readonly IStoreRepository _repository;
		private readonly IMapper _mapper;
		public ShippingDetailsViewComponent(IStoreRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
