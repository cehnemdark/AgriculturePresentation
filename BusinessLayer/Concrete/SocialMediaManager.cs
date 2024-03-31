using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SocialMediaManager : ISocialMediaService
	{
		ISociadMediaDal _sociadMediaDal;

		public SocialMediaManager(ISociadMediaDal sociadMediaDal)
		{
			_sociadMediaDal = sociadMediaDal;
		}

		public void Delete(SocialMedia t)
		{
			_sociadMediaDal.Delete(t);
		}

		public SocialMedia GetById(int id)
		{
			return _sociadMediaDal.GetById(id);
		}

		public List<SocialMedia> GetListAll()
		{
			return _sociadMediaDal.GetListAll();
		}

		public void Insert(SocialMedia t)
		{
			_sociadMediaDal.Insert(t);
		}

		public void Update(SocialMedia t)
		{
			_sociadMediaDal.Update(t);
		}
	}
}
