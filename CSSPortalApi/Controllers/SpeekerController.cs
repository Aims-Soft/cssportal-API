using System;
using Microsoft.AspNetCore.Mvc;
using CSSPortalApi.Services;
using CSSPortalApi.Entities;
using Microsoft.Extensions.Options;
using CSSPortalApi.Configuration;

namespace CSSPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class SpeekerController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public SpeekerController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getWorkspaceType")]
    public IActionResult getWorkspaceType()
    {
        try
        {
            cmd = "select * from tbl_jobSpace";
            var response = dapperQuery.Qry<JobSpace>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getExperience")]
    public IActionResult getExperience()
    {
        try
        {
            cmd = "select * from tbl_experience where isdeleted=0";
            var response = dapperQuery.Qry<Experience>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getBenefit")]
    public IActionResult getBenefit()
    {
        try
        {
            cmd = "select * from tbl_Benefit where isDeleted=0";
            var response = dapperQuery.Qry<Benefit>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getSkills")]
    public IActionResult getSkills()
    {
        try
        {
            cmd = "select * from tbl_skills where isDeleted=0";
            var response = dapperQuery.Qry<Skills>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getJobStatus")]
    public IActionResult getJobStatus()
    {
        try
        {
            cmd = "select * from tbl_jobstatus";
            var response = dapperQuery.Qry<JobStatus>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost("saveJob")]
    public IActionResult saveJob(SaveJob model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveJob", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveJobStatus")]
    public IActionResult saveJobStatus(SaveJobStatus model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveJobStatus", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveJobStatusIsPauseClosed")]
    public IActionResult saveJobStatusIsPauseClosed(SaveJobStatusIsPauseClosed model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveJobStatuIsPauseClose", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveJobApplication")]
    public IActionResult saveJobApplication(SaveJobApplication model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveJobApplication", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
    [HttpPost("saveJobApplicationStatus")]
    public IActionResult saveJobApplicationStatus(SaveJobApplicationStatus model)
    {
        try
        {
            var response = dapperQuery.SPReturn("sp_saveJobApplicationStatus", model, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return Ok(e.Message);
        }
    }
}