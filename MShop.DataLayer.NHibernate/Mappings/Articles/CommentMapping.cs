﻿using FluentNHibernate.Mapping;
using MShop.DataLayer.NHibernate.Entities.Articles;

namespace MShop.DataLayer.NHibernate.Mappings.Articles
{
	public class CommentMapping : ClassMap<Comment>
	{
		public CommentMapping()
		{
			Table("Comments");
			Id(m => m.Id);
			Map(m => m.AddedDate);
			Map(m => m.AddedBy);
			Map(m => m.AddedByEmail);
			Map(m => m.AddedByIp);
			Map(m => m.Body);
			//Map(m => m.ArticleId);
			References(m => (Article)m.Article).Column("ArticleId").Cascade.All();
		}
	}
}
