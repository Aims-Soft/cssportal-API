using System;
using Microsoft.AspNetCore.Mvc;
using CSSPortalApi.Services;
using CSSPortalApi.Entities;
using Microsoft.Extensions.Options;
using CSSPortalApi.Configuration;

namespace CSSPortalApi.Controllers;

[ApiController]
[Route("[controller]")]

public class WebsiteController : ControllerBase
{
    private readonly IOptions<conStr> _dbCon;
    private string cmd;

    public WebsiteController(IOptions<conStr> dbCon)
    {
        _dbCon = dbCon;
    }
    [HttpGet("getExploreJob")]
    public IActionResult getExploreJob()
    {
        try
        {
            cmd = "select * from view_exploreJob";
            var response = dapperQuery.Qry<ExploreJob>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getCompanies")]
    public IActionResult getCompanies()
    {
        try
        {
            cmd = "select * from view_Companies";
            var response = dapperQuery.Qry<Companies>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("getContactUs")]
    public IActionResult getContactUs()
    {
        try
        {
            cmd = "select contactUSID,userName,email,contact,userMessage,createdOn,readMsg from tbl_contact_us where isDeleted=0 order by contactUSID desc";
            var response = dapperQuery.Qry<ContactUs>(cmd, _dbCon);
            return Ok(response);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost("saveContactUS")]
        public IActionResult saveContactUS(ContactUsCreation model)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_contactUS", model, _dbCon);
                return Ok(response);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
    [HttpPost("saveReadMsg")]
        public IActionResult saveReadMsg(ReadMsgCreation model)
        {
            try
            {
                var response = dapperQuery.SPReturn("sp_readMsg",model,_dbCon);
                return Ok(response);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
    
}