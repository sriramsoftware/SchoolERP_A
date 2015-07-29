using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
using System.Data;

public partial class TMSchoolMgmt_AccountManager_AccountManager : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("../Default.aspx?var=Logout");
            }
            else
            {
                Getuser();
                BindActiveTab();
                GetInBoxCount();
            }
        }
    }
    protected void Getuser()
    {
        DataTable dtTeacher = TMSFacultyDetails.GetSearch(null, Convert.ToInt32(Session["UserId"]), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null).Tables[0];
        int dtteachercnt = dtTeacher.Rows.Count;
        if (dtTeacher.Rows.Count > 0)
        {
            lblUser.Text = dtTeacher.Rows[0]["FD_FirstName"].ToString() + " " + dtTeacher.Rows[0]["FD_LastName"].ToString();
            imageteacher.ImageUrl = dtTeacher.Rows[0]["FD_Image"].ToString();
            if (imageteacher.ImageUrl == "")
            {
                imageteacher.ImageUrl = "~/UploadImages/TeacherPhoto/UserNoImage.jpg";
                Session["Imageurlt"] = imageteacher.ImageUrl;
            }
            else
            {
                Session["Imageurlt"] = imageteacher.ImageUrl;
            }
        }
    }
    public void BindAccountLink(object sender, EventArgs e)
    {
        if (ListMyAccount.Style.Value == "display:none;")
        {
            ListMyAccount.Style.Add("display", "block");
        }
        else
        {
            ListMyAccount.Style.Add("display", "none");
        }
    }
    protected void BindActiveTab()
    {
        //string s = this.Page.Request.FilePath;
        //string _required = s.Substring(s.LastIndexOf('/') + 1);
        //string[] St = s.Split('/');
        //if (_required == "Dashboard.aspx")
        //{
        //}
        //else if (_required == "Salarydetails.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "selectedlinks1");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "TimeTable.aspx")
        //{

        //    timetables.Attributes.Add("class", "selectedlinks1");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "courceandSyllabus1.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "selectedlinks1");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Faculty.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "selectedlinks1");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "MyStudents.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "selectedlinks1");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Examinations.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "selectedlinks1");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Results.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "selectedlinks1");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "MedicalHistory.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "selectedlinks1");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "UploadFunStuff.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "selectedlinks1");
        //    Facultys.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "studentattendancerecord.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "selectedlinks1");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "StudeentAttendance.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "selectedlinks1");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "AttendanceRecord.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "selectedlinks1");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "TransportDetails.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "selectedlinks1");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Teacherhomework.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "selectedlinks1");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Teachernote.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "selectedlinks1");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Monitor.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "selectedlinks1");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "EditMonitor.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "selectedlinks1");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Announcement.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "selectedlinks1");
        //    review.Attributes.Add("class", "");
        //}
        //else if (_required == "Parentreviews.aspx")
        //{
        //    timetables.Attributes.Add("class", "");
        //    cources.Attributes.Add("class", "");
        //    classmatess.Attributes.Add("class", "");
        //    examinationss.Attributes.Add("class", "");
        //    resultss.Attributes.Add("class", "");
        //    medical.Attributes.Add("class", "");
        //    attend.Attributes.Add("class", "");
        //    transport.Attributes.Add("class", "");
        //    eventss.Attributes.Add("class", "");
        //    diarynotes.Attributes.Add("class", "");
        //    Monitor.Attributes.Add("class", "");
        //    salarydetail.Attributes.Add("class", "");
        //    special.Attributes.Add("class", "");
        //    review.Attributes.Add("class", "selectedlinks1");
        //}
    }

    private void GetInBoxCount()
    {
        lblMsgUnReadCnt.Text = "(" + TMSMyMessageDetails.GetInboxCount(Convert.ToInt32(Session["UserId"])).ToString() + ")";
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["LoginName"] != null)
            {
                ILog logger = log4net.LogManager.GetLogger("" + Session["LoginName"].ToString() + "(Teacher)");
                logger.Info("Logout Time,This is info message");
                logger.Debug("Logout Time,This is Debug message");
                logger.Error("Logout Time,This is Error message");
                logger.Warn("Logout Time,This is Warn message");
                logger.Fatal("Logout Time,This is Fatal message");
            }
            Session.Abandon();
            Response.Redirect("../Default.aspx?var=Logout", false);
        }
        catch (Exception ex)
        {
        }
    }
    protected void imageteacher_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            Response.Redirect("AccountManagerDashboard.aspx");
        }
        catch (Exception) { }
    }
}
