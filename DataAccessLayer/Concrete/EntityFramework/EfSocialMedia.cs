using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repository;

namespace DataAccessLayer.Concrete.EntityFramework
{
	public class EfSocialMedia : GenericRepository<SocialMedia>, ISociadMediaDal

	{
	}
}
