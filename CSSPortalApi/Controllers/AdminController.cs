using System;
using Microsoft.AspNetCore.Mvc;
using CSSPortalApi.Services;
using CSSPortalApi.Entities;
using Microsoft.Extensions.Options;
using CSSPortalApi.Configuration;

namespace CSSPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class AdminController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public AdminController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getSubject")]   
    public IActionResult getSubject()
    {
        try
        {
            cmd = "select * from tbl_subject where isDeleted=0";
            var response = dapperQuery.Qry<GetSubject>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getTopic")]
    public IActionResult getTopic(int subjectID)
    {
        try
        {
            cmd = "select topicID,topicTitle,subjectID from tbl_topic where isDeleted=0 and subjectID='"+subjectID+"'";
            var response = dapperQuery.Qry<GetTopic>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getSpeaker")]
    public IActionResult getSpeaker()
    {
        try
        {
            cmd = "select userID,userName from tbl_user where isDeleted=0 and userTypeID=2";
            var response = dapperQuery.Qry<GetSpeeker>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("CompanyJobs")]
    public IActionResult CompanyJobs(int companyID)
    {
        try
        {
            if (companyID == null || companyID == 0)
            {
                cmd = "select * from view_CompanyJobs order by jobTitle";
            }
            else
            {
                cmd = "select * from view_CompanyJobs where companyID=" + companyID + " order by jobTitle";
            }
            
            var response = dapperQuery.Qry<CompanyJob>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("AllJobs")]
    public IActionResult AllJobs(int companyID)
    {
        try
        {
            if (companyID == null || companyID == 0)
            {
                cmd = "select distinct * from view_alljobs";
            }
            else
            {
                cmd = "select distinct * from view_alljobs where companyID="+companyID+"";
            }
            var response = dapperQuery.Qry<AllJobs>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getCompanyDetail")]
    public IActionResult getCompanyDetail()
    {
        try
        {
            cmd = "select * from view_companyDetails order by companyID desc";
            var response = dapperQuery.Qry<CompanyDetails>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getAllTrainer")]
    public IActionResult getAllTrainer()
    {
        try
        {
            cmd = "select * from view_getAllTrainers";
            var response = dapperQuery.Qry<AllTrainer>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getTrainerCareer")]
    public IActionResult getTrainerCareer()
    {
        try
        {
            cmd = "select * from view_getTrainersCareer";
            var response = dapperQuery.Qry<AllTrainer>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getAllUser")]
        public IActionResult getAllUser()
        {
            try
            {
                cmd = "select * from view_getAllUsers";
                var response = dapperQuery.Qry<AllTrainer>(cmd, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    [HttpGet("getUserJobDetails")]
    public IActionResult getUserJobDetails(int userID)
    {
        try
        {
            cmd = "select * from view_userJobDetails where userID="+userID+"";
            var response = dapperQuery.Qry<UserJobDetails>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getUserJobDomain")]
    public IActionResult getUserJobDomain(int userID)
    {
        try
        {
            cmd = "select * from view_userJobDomain where userID="+userID+"";
            var response = dapperQuery.Qry<UserJobDomains>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getSessionType")]
    public IActionResult getSessionType()
    {
        try
        {
            cmd = "select sessionTypeID,sessionTypeName from tbl_session_Type where isdeleted=0";
            var response = dapperQuery.Qry<SessionType>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getAllSession")]
    public IActionResult getAllSession()
    {
        try
        {
            cmd = "select distinct * from view_getAllSessions order by createdOn desc";
            var response = dapperQuery.Qry<AllSessions>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getComingSession")]
    public IActionResult getComingSession()
    {
        try
        {
            cmd = "select distinct  * from view_getComingSessions where date > GETDATE()";
            var response = dapperQuery.Qry<AllSessions>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost("updateUserStatus")]
    public IActionResult updateUserStatus(LoginStatus model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_updateUserStatus", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("updateSessionStatus")]
    public IActionResult updateSessionStatus(SessionStatus model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_updateSessionStatus", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveTrainerByAdmin")]
    public IActionResult saveTrainerByAdmin(TrainerByAdmin model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveTrainerByAdmin", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveSessionByAdmin")]
    public IActionResult saveSessionByAdmin(SessionByAdmin model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveSessionByAdmin", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
}