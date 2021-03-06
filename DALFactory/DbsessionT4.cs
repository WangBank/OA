﻿

 


using DAL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALFactory
{
   public partial class DbSession: IDbSession
    {
   
	    public IActionInfoDal ActionInfoDal
        {
            get { return StaticDalFactory.GetActionInfoDal(); }
        }
   
	    public IBooksDal BooksDal
        {
            get { return StaticDalFactory.GetBooksDal(); }
        }
   
	    public IDepartmentDal DepartmentDal
        {
            get { return StaticDalFactory.GetDepartmentDal(); }
        }
   
	    public IFileInfoDal FileInfoDal
        {
            get { return StaticDalFactory.GetFileInfoDal(); }
        }
   
	    public IKeyWordsRankDal KeyWordsRankDal
        {
            get { return StaticDalFactory.GetKeyWordsRankDal(); }
        }
   
	    public IR_UserInfo_ActionInfoDal R_UserInfo_ActionInfoDal
        {
            get { return StaticDalFactory.GetR_UserInfo_ActionInfoDal(); }
        }
   
	    public IRoleInfoDal RoleInfoDal
        {
            get { return StaticDalFactory.GetRoleInfoDal(); }
        }
   
	    public ISearchDetailsDal SearchDetailsDal
        {
            get { return StaticDalFactory.GetSearchDetailsDal(); }
        }
   
	    public IUserInfoDal UserInfoDal
        {
            get { return StaticDalFactory.GetUserInfoDal(); }
        }
   
	    public IWF_ItemDal WF_ItemDal
        {
            get { return StaticDalFactory.GetWF_ItemDal(); }
        }
   
	    public IWF_StepDal WF_StepDal
        {
            get { return StaticDalFactory.GetWF_StepDal(); }
        }
   
	    public IWF_TempDal WF_TempDal
        {
            get { return StaticDalFactory.GetWF_TempDal(); }
        }

}
}
