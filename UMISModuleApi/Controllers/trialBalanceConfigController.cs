using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UMISModuleAPI.Models;
using UMISModuleAPI.Services;
using UMISModuleAPI.Entities;
using Microsoft.Extensions.Options;
using UMISModuleAPI.Configuration;
using UMISModuleApi.Entities;

namespace UMISModuleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class trialBalanceConfigController : Controller
    {
        private readonly IOptions<conStr> _dbCon;
        private string cmd;
        
        //connection string for fmis DB
        private string dbCon2 = "Data Source=tcp:135.181.62.34,1433;Initial Catalog=aimsFMIS;Persist Security Info=True;User ID=devumis;Password=D@v$m!s@721";
        
        public trialBalanceConfigController (IOptions<conStr> dbCon)
        {
            _dbCon = dbCon;
            
        }


        [HttpGet("getTrialBalanceNameGroups")]
        public ActionResult getTrialBalanceNameGroups(int trialBalanceGroupID)
        {
            try
            {
                cmd = @"select tbng.trialBalanceNameGroupID, tbng.trialBalanceGroupID, tbn.trialBalanceShortName, tbn.trialBalanceFullName, tbn.trialBalanceNameID,tbn.sectionLocID,secloc.sectionLocName
                    from tbl_trial_balance_name_groups as tbng right outer join 
	                 aimsumis.dbo.tbl_trial_balance_name as tbn on tbn.trialBalanceNameID = tbng.trialBalanceNameID and 
                    tbng.trialBalanceGroupID = "+trialBalanceGroupID+" and tbng.isDeleted = 0 inner join aimsumis.dbo.tbl_section_loc as secloc on secloc.sectionLocID=tbn.sectionLocID";
                var row =dapperQuery.StrConQry<trialbalanceNameGroup>(cmd, dbCon2); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        [HttpPost("saveTrialBalanceGroup")]
        public ActionResult saveTrialBalanceGroup(trialBalanceGroupCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturnFMIS("sp_TrialBalanceGroupCrud",model,dbCon2);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        [HttpPost("saveTrialBalanceNameGroup")]
        public ActionResult saveTrialBalanceGroup(trialBalanceNamegroupCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturnFMIS("sp_TrialBalanceNameGroupCrud",model,dbCon2);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        [HttpPost("saveTrialBalanceNameBudget")]
        public ActionResult saveTrialBalanceNameBudget(trialBalanceBudgetCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturnFMIS("sp_trialBalance_Budget_type",model,dbCon2);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        [HttpGet("getTrialBalanceNameBudget")]
        public ActionResult getTrialBalanceNameBudget(int trialBalanceNameID)
        {
            try
            {
                cmd="select tbBud.trialBalanceNameBudgetTypeID,tbBud.budgetTypeID,tbBud.trialBalanceNameID,bud.budgetTypeName,tb.trialBalanceFullName "+
                    " from tbl_trial_balance_name_budget_type tbBud  inner join "+
                    " dbo.tbl_budget_type as bud on bud.budgetTypeID=tbBud.budgetTypeID and tbBud.isDeleted=0  right outer join "+
                    " aimsumis.dbo.tbl_trial_balance_name as tb on tb.trialBalanceNameID=tbBud.trialBalanceNameID "+
                    " where tbBud.trialBalanceNameID="+trialBalanceNameID+"";
                var row =dapperQuery.StrConQry<trialBalanceBudget>(cmd, dbCon2); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }


        [HttpGet("getTrialBalanceGroups")]
        public ActionResult getTrialBalanceGroups()
        {
            try
            {
                cmd="select trialBalanceGroupID,trialBalanceGroupTitle From tbl_trial_balance_groups where isDeleted=0";
                var row =dapperQuery.StrConQry<TrialBalanceGroups>(cmd, dbCon2); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        //save TrialBalanceHeadGroup
        [HttpPost("saveTrialBalanceheadGroup")]
        public ActionResult saveTrialBalanceheadGroup(TrialBalanceHeadGroupCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturnFMIS("sp_trialBalanceNameHeadCRUD",model,dbCon2);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        //get TrialBalanceHeadGroup
        [HttpGet("getTrialBalanceHeadGroup")]
        public ActionResult getTrialBalanceHeadGroup()
        {
            try
            {
                cmd="select *from tbl_trial_balance_head_group where isDeleted=0";
                var row =dapperQuery.StrConQry<TrialBalanceHeadGroup>(cmd, dbCon2); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }
        //TrialBalanceHeadGroupDetail
        [HttpPost("saveTrialBalanceheadDetail")]
        public ActionResult saveTrialBalanceheadDetail(trialBalanceHeadDetailCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturnFMIS("sp_tBHeadGroupDetail",model,dbCon2);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        //TrialBalanceHeadGroupDetail
        [HttpGet("getTrialBalanceHeadDetail")]
        public ActionResult getTrialBalanceHeadDetail(int tbHeadGroupID)
        {
            try
            {
                cmd="select tbheadDet.tbHeadGroupDetailID,tbheadDet.tbHeadGroupID,tbHead.tbHeadGroupTitle,tbheadDet.coaID,coa.accountLevel1,coa.accountLevel2,coa.coaCode,coa.coaTitle " +
                "from tbl_trial_balance_head_group_detail tbheadDet inner join " +
                "dbo.tbl_trial_balance_head_group as tbHead on tbHead.tbHeadGroupID=tbheadDet.tbHeadGroupID INNER join " +
                "dbo.tbl_COA as coa on coa.coaID=tbheadDet.coaID " +
                "WHERE tbheadDet.tbHeadGroupID="+tbHeadGroupID+" and tbheadDet.isDeleted=0";
                var row =dapperQuery.StrConQry<trialBalanceHeadDetail>(cmd, dbCon2); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        //drop down 
        [HttpGet("TrialBalanceHeadGroup")]
        public ActionResult TrialBalanceHeadGroup()
        {
            try
            {
                cmd="select tbHeadGroupID,tbHeadGroupTitle from tbl_trial_balance_head_group where isDeleted=0";
                var row =dapperQuery.StrConQry<trialBalanceHeadDetail>(cmd, dbCon2); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        [HttpGet("getViewTrialBalanceConfig")]
        public ActionResult getViewTrialBalanceConfig()
        {
            try
            {
                cmd="SELECT * FROM view_trialBalanceConfig";
                var row =dapperQuery.Qry<trialBalance>(cmd, _dbCon); 
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        [HttpPost("saveTrialBalanceConfig")]
        public ActionResult saveTrialBalanceConfig(trialBalanceCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturn("sp_trialbalanceConfigCrud",model,_dbCon);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        // proc sp_trialBalanceCOA => nhaumis
        [HttpPost("saveTrialBalanceCOA")]
        public ActionResult saveTrialBalanceCOA(trialBalanceCoaCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturn("sp_trialBalanceCOA",model,_dbCon);
                return Ok(row);
            }
            catch(Exception e )
            {
                return Ok(e);
            }
        }

        //update on the basis of tbheadgroupID
        [HttpGet("getTbHeadCoa")]
        public ActionResult getTbHeadCoa(int tbHeadGroupID)
        {
            try
            {
                cmd="select *from view_trialBalanceCOA where tbHeadGroupID="+tbHeadGroupID+" ";                
                var row =dapperQuery.Qry<trialBalanceCoa>(cmd, _dbCon);
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        [HttpGet("getTrialBalanceCOA")]
        public ActionResult getTrialBalanceCOA(int trialBalanceNameID)
        {
            try
            {
                cmd="SELECT   tb.trialBalanceNameCOAID, tb.trialBalanceNameID, tbcoa.trialBalanceShortName, tbcoa.trialBalanceFullName, coa.coaID, coa.accountLevel1, coa.accountLevel2, coa.coaCode, coa.coaTitle, 0 AS selection " +
                    "FROM aimsFMIS.dbo.tbl_trial_balance_name_coa AS tb INNER JOIN " +
                    "aimsumis.dbo.tbl_trial_balance_name AS tbcoa ON tb.trialBalanceNameID = tbcoa.trialBalanceNameID INNER JOIN " +
                    "aimsFMIS.dbo.tbl_COA AS coa ON coa.coaID = tb.coaID " +
                    "where tb.isDeleted=0 and tb.trialBalanceNameID="+trialBalanceNameID+" ";        
                var row =dapperQuery.Qry<trialBalanceCoa>(cmd, _dbCon);
                return Ok(row);
            }
            catch (Exception e)
            {
                return Ok(e);
            }  
        }

        [HttpPost("saveUserTrialbalance")]
        public IActionResult saveUserTrialbalance(userTrialBalanceCreation model)
        {
            try
            {
                var row = dapperQuery.SPReturn("sp_userTrialBalanceCrud",model,_dbCon);
                return Ok(row);
            }
            catch(Exception e)
            {
                return Ok(e);
            }
        }
    }
       
}