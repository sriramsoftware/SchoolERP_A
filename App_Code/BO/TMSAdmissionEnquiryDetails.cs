using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSAdmissionEnquiryDetails
{
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? aedEnquiryId, System.String aedChildFirstName, System.String aedChildMiddleName, System.String aedChildLastName, System.DateTime? aedDateOfBirth, System.String aedGender, System.String aedGurdianName, System.String aedAddress, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedPinCode, System.String aedLandLineNo, System.String aedMobileNo, System.String aedEmailId, System.String aedAdminssionClass, System.String aedPercentage, System.Int64? aedCounsellorId, System.String aedRemark, System.String aedComment, System.DateTime? aedDate, System.Int32? aedStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aedEnquiryId, aedChildFirstName, aedChildMiddleName, aedChildLastName, aedDateOfBirth, aedGender, aedGurdianName, aedAddress, aedCity, aedState, aedProgram, aedPinCode, aedLandLineNo, aedMobileNo, aedEmailId, aedAdminssionClass, aedPercentage, aedCounsellorId, aedRemark, aedComment, aedDate, aedStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
        return ds;
	}


    public static DataSet GetSearch(TMSAdmissionEnquiryDetails searchObject)
	{
        return GetSearch(searchObject.AEDEnquiryId, searchObject.AEDChildFirstName, searchObject.AEDChildMiddleName, searchObject.AEDChildLastName, searchObject.AEDDateOfBirth, searchObject.AEDGender, searchObject.AEDGurdianName, searchObject.AEDAddress, searchObject.AEDCity, searchObject.AEDState, searchObject.AEDProgram, searchObject.AEDPinCode, searchObject.AEDLandLineNo, searchObject.AEDMobileNo, searchObject.AEDEmailId, searchObject.AEDAdminssionClass, searchObject.AEDPercentage, searchObject.AEDCounsellorId, searchObject.AEDRemark, searchObject.AEDComment, searchObject.AEDDate, searchObject.AEDStatus);
	}
	
	/// <summary>
	/// Returns all TMSAdmissionEnquiryDetails objects.
	/// </summary>
	/// <returns>List of all TMSAdmissionEnquiryDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
	{
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion



    public static DataSet ViewAllAdmissionEnquiryDetails(System.Int64? aedEnquiryId, System.String aedChildFirstName, System.String aedGender, System.String aedGurdianName, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedEmailId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspViewAllAdmissionEnquiryDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, aedEnquiryId, aedChildFirstName, aedGender, aedGurdianName, aedCity, aedState, aedProgram, aedEmailId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

