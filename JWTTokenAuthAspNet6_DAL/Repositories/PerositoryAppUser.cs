using JWTTokenAuthAspNet6_DAL.Contracts;
using JWTTokenAuthAspNet6_DAL.Data;
using JWTTokenAuthAspNet6_DAL.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthAspNet6_DAL.Repositories
{
    public class PerositoryAppUser : IRepository<AppUser>
    {
        //private readonly AppDbContext _appDbcontext;
        //private readonly ILogger _logger;
        //public PerositoryAppUser(ILogger<AppUser> logger)
        //{
        //    _logger = logger;
        //}

        //public async Task<AppUser> Create(AppUser appUser)
        //{
        //    try
        //    {
        //        if (appUser != null)
        //        {
        //            var obj = _appDbcontext.Add<AppUser>(appUser);
        //            await _appDbcontext.SaveChangesAsync();
        //            return obj.Entity;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //}

        //public void Delete(AppUser appUser)
        //{
        //    try
        //    {
        //        if (appUser != null)
        //        {
        //            var obj = _appDbcontext.Remove<AppUser>(appUser);
        //            if (obj != null)
        //            {
        //                _appDbcontext.SaveChanges();
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public IEnumerable<AppUser> GetAll()
        //{
        //    try
        //    {
        //        var obj = _appDbcontext.AppUsers.ToList();
        //        if (obj != null)
        //            return obj;
        //        else
        //            return null;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public AppUser GetById(int id)
        //{
        //    try
        //    {
        //        if (id!=null)
        //        {
        //            var obj = _appDbcontext.AppUsers.FirstOrDefault(x=>x.Id==id);
        //            if (obj != null)
        //                return obj;
        //            else
        //                return null;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public void Update(AppUser appUser)
        //{
        //    try
        //    {
        //        if (appUser!=null)
        //        {
        //            var obj = _appDbcontext.Update(appUser);
        //            if (obj != null)
        //                _appDbcontext.SaveChanges();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}
    }
}
