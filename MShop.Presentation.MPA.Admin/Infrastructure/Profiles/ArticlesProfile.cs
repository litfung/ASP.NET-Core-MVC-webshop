﻿using AutoMapper;
using MShop.DataLayer.EF.Entities.Articles;
using MShop.DataLayer.EF.Providers.Articles;
using MShop.Presentation.MPA.Admin.Models.Articles;
using MShop.ViewComponents.Models; 

namespace MShop.Presentation.MPA.Admin.Infrastructure.Profiles
{
	public class ArticlesProfile : Profile
	{
		public ArticlesProfile()
		{
			CreateMap<ArticleProvider, ArticleItemViewModel>()
				.ForMember(a => a.Location, p => p.ResolveUsing(provider =>
				{
					if (!string.IsNullOrEmpty(provider.Country) && !string.IsNullOrEmpty(provider.City))
						return provider.Country + ", " + provider.City;

					return string.Empty;
				}));

			CreateMap<ArticleProvider, ArticleItemViewModel>();
			CreateMap<ArticleProvider, ManageArticleItemViewModel>();
			CreateMap<AddArticleViewModel, Article>();
			CreateMap<Article, EditArticleViewModel>();
			CreateMap<EditArticleViewModel, Article>();
			CreateMap<Category, Models.Articles.CategoryItemViewModel>();
			CreateMap<AddCategoryViewModel, Category>();
			CreateMap<Category, EditCategoryViewModel>();
			CreateMap<EditCategoryViewModel, Category>();
			CreateMap<CommentProvider, ManageCommentItemViewModel>();
			CreateMap<Comment, EditCommentViewModel>();
			CreateMap<EditCommentViewModel, Comment>();
			CreateMap<ArticleProvider, ManageArticleItemViewModel>();
		}
	}
}