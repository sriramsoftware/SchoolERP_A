/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/21/2012 1:05:20 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSAdmissionEnquiryDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AdmissionEnquiryDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _aedEnquiryId;
	private System.String _aedChildFirstName;
	private System.String _aedChildMiddleName;
	private System.String _aedChildLastName;
	private System.DateTime? _aedDateOfBirth;
	private System.String _aedGender;
	private System.String _aedGurdianName;
	private System.String _aedAddress;
	private System.String _aedCity;
	private System.String _aedState;
	private System.String _aedProgram;
	private System.String _aedPinCode;
	private System.String _aedLandLineNo;
	private System.String _aedMobileNo;
	private System.String _aedEmailId;
	private System.String _aedAdminssionClass;
	private System.String _aedPercentage;
	private System.Int64? _aedCounsellorId;
	private System.String _aedRemark;
	private System.String _aedComment;
	private System.DateTime? _aedDate;
	private System.Int32? _aedStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? AEDEnquiryId
	{
		get
		{
			return _aedEnquiryId;
		}
		set
		{
			_aedEnquiryId = value;
		}
	}
	
	public System.String AEDChildFirstName
	{
		get
		{
			return _aedChildFirstName;
		}
		set
		{
			_aedChildFirstName = value;
		}
	}
	
	public System.String AEDChildMiddleName
	{
		get
		{
			return _aedChildMiddleName;
		}
		set
		{
			_aedChildMiddleName = value;
		}
	}
	
	public System.String AEDChildLastName
	{
		get
		{
			return _aedChildLastName;
		}
		set
		{
			_aedChildLastName = value;
		}
	}
	
	public System.DateTime? AEDDateOfBirth
	{
		get
		{
			return _aedDateOfBirth;
		}
		set
		{
			_aedDateOfBirth = value;
		}
	}
	
	public System.String AEDGender
	{
		get
		{
			return _aedGender;
		}
		set
		{
			_aedGender = value;
		}
	}
	
	public System.String AEDGurdianName
	{
		get
		{
			return _aedGurdianName;
		}
		set
		{
			_aedGurdianName = value;
		}
	}
	
	public System.String AEDAddress
	{
		get
		{
			return _aedAddress;
		}
		set
		{
			_aedAddress = value;
		}
	}
	
	public System.String AEDCity
	{
		get
		{
			return _aedCity;
		}
		set
		{
			_aedCity = value;
		}
	}
	
	public System.String AEDState
	{
		get
		{
			return _aedState;
		}
		set
		{
			_aedState = value;
		}
	}
	
	public System.String AEDProgram
	{
		get
		{
			return _aedProgram;
		}
		set
		{
			_aedProgram = value;
		}
	}
	
	public System.String AEDPinCode
	{
		get
		{
			return _aedPinCode;
		}
		set
		{
			_aedPinCode = value;
		}
	}
	
	public System.String AEDLandLineNo
	{
		get
		{
			return _aedLandLineNo;
		}
		set
		{
			_aedLandLineNo = value;
		}
	}
	
	public System.String AEDMobileNo
	{
		get
		{
			return _aedMobileNo;
		}
		set
		{
			_aedMobileNo = value;
		}
	}
	
	public System.String AEDEmailId
	{
		get
		{
			return _aedEmailId;
		}
		set
		{
			_aedEmailId = value;
		}
	}
	
	public System.String AEDAdminssionClass
	{
		get
		{
			return _aedAdminssionClass;
		}
		set
		{
			_aedAdminssionClass = value;
		}
	}
	
	public System.String AEDPercentage
	{
		get
		{
			return _aedPercentage;
		}
		set
		{
			_aedPercentage = value;
		}
	}
	
	public System.Int64? AEDCounsellorId
	{
		get
		{
			return _aedCounsellorId;
		}
		set
		{
			_aedCounsellorId = value;
		}
	}
	
	public System.String AEDRemark
	{
		get
		{
			return _aedRemark;
		}
		set
		{
			_aedRemark = value;
		}
	}
	
	public System.String AEDComment
	{
		get
		{
			return _aedComment;
		}
		set
		{
			_aedComment = value;
		}
	}
	
	public System.DateTime? AEDDate
	{
		get
		{
			return _aedDate;
		}
		set
		{
			_aedDate = value;
		}
	}
	
	public System.Int32? AEDStatus
	{
		get
		{
			return _aedStatus;
		}
		set
		{
			_aedStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("AED_EnquiryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_ChildFirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_ChildMiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_ChildLastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_DateOfBirth", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Gender", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_GurdianName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Address", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_City", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_State", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Program", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_PinCode", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_LandLineNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_MobileNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_EmailId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_AdminssionClass", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Percentage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_CounsellorId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Remark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Comment", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AED_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (AEDEnquiryId == null)
		dr["AED_EnquiryId"] = DBNull.Value;
		else
		dr["AED_EnquiryId"] = AEDEnquiryId;
		
		if (AEDChildFirstName == null)
		dr["AED_ChildFirstName"] = DBNull.Value;
		else
		dr["AED_ChildFirstName"] = AEDChildFirstName;
		
		if (AEDChildMiddleName == null)
		dr["AED_ChildMiddleName"] = DBNull.Value;
		else
		dr["AED_ChildMiddleName"] = AEDChildMiddleName;
		
		if (AEDChildLastName == null)
		dr["AED_ChildLastName"] = DBNull.Value;
		else
		dr["AED_ChildLastName"] = AEDChildLastName;
		
		if (AEDDateOfBirth == null)
		dr["AED_DateOfBirth"] = DBNull.Value;
		else
		dr["AED_DateOfBirth"] = AEDDateOfBirth;
		
		if (AEDGender == null)
		dr["AED_Gender"] = DBNull.Value;
		else
		dr["AED_Gender"] = AEDGender;
		
		if (AEDGurdianName == null)
		dr["AED_GurdianName"] = DBNull.Value;
		else
		dr["AED_GurdianName"] = AEDGurdianName;
		
		if (AEDAddress == null)
		dr["AED_Address"] = DBNull.Value;
		else
		dr["AED_Address"] = AEDAddress;
		
		if (AEDCity == null)
		dr["AED_City"] = DBNull.Value;
		else
		dr["AED_City"] = AEDCity;
		
		if (AEDState == null)
		dr["AED_State"] = DBNull.Value;
		else
		dr["AED_State"] = AEDState;
		
		if (AEDProgram == null)
		dr["AED_Program"] = DBNull.Value;
		else
		dr["AED_Program"] = AEDProgram;
		
		if (AEDPinCode == null)
		dr["AED_PinCode"] = DBNull.Value;
		else
		dr["AED_PinCode"] = AEDPinCode;
		
		if (AEDLandLineNo == null)
		dr["AED_LandLineNo"] = DBNull.Value;
		else
		dr["AED_LandLineNo"] = AEDLandLineNo;
		
		if (AEDMobileNo == null)
		dr["AED_MobileNo"] = DBNull.Value;
		else
		dr["AED_MobileNo"] = AEDMobileNo;
		
		if (AEDEmailId == null)
		dr["AED_EmailId"] = DBNull.Value;
		else
		dr["AED_EmailId"] = AEDEmailId;
		
		if (AEDAdminssionClass == null)
		dr["AED_AdminssionClass"] = DBNull.Value;
		else
		dr["AED_AdminssionClass"] = AEDAdminssionClass;
		
		if (AEDPercentage == null)
		dr["AED_Percentage"] = DBNull.Value;
		else
		dr["AED_Percentage"] = AEDPercentage;
		
		if (AEDCounsellorId == null)
		dr["AED_CounsellorId"] = DBNull.Value;
		else
		dr["AED_CounsellorId"] = AEDCounsellorId;
		
		if (AEDRemark == null)
		dr["AED_Remark"] = DBNull.Value;
		else
		dr["AED_Remark"] = AEDRemark;
		
		if (AEDComment == null)
		dr["AED_Comment"] = DBNull.Value;
		else
		dr["AED_Comment"] = AEDComment;
		
		if (AEDDate == null)
		dr["AED_Date"] = DBNull.Value;
		else
		dr["AED_Date"] = AEDDate;
		
		if (AEDStatus == null)
		dr["AED_Status"] = DBNull.Value;
		else
		dr["AED_Status"] = AEDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		AEDEnquiryId = dr["AED_EnquiryId"] != DBNull.Value ? Convert.ToInt64(dr["AED_EnquiryId"]) : AEDEnquiryId = null;
		AEDChildFirstName = dr["AED_ChildFirstName"] != DBNull.Value ? Convert.ToString(dr["AED_ChildFirstName"]) : AEDChildFirstName = null;
		AEDChildMiddleName = dr["AED_ChildMiddleName"] != DBNull.Value ? Convert.ToString(dr["AED_ChildMiddleName"]) : AEDChildMiddleName = null;
		AEDChildLastName = dr["AED_ChildLastName"] != DBNull.Value ? Convert.ToString(dr["AED_ChildLastName"]) : AEDChildLastName = null;
		AEDDateOfBirth = dr["AED_DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(dr["AED_DateOfBirth"]) : AEDDateOfBirth = null;
		AEDGender = dr["AED_Gender"] != DBNull.Value ? Convert.ToString(dr["AED_Gender"]) : AEDGender = null;
		AEDGurdianName = dr["AED_GurdianName"] != DBNull.Value ? Convert.ToString(dr["AED_GurdianName"]) : AEDGurdianName = null;
		AEDAddress = dr["AED_Address"] != DBNull.Value ? Convert.ToString(dr["AED_Address"]) : AEDAddress = null;
		AEDCity = dr["AED_City"] != DBNull.Value ? Convert.ToString(dr["AED_City"]) : AEDCity = null;
		AEDState = dr["AED_State"] != DBNull.Value ? Convert.ToString(dr["AED_State"]) : AEDState = null;
		AEDProgram = dr["AED_Program"] != DBNull.Value ? Convert.ToString(dr["AED_Program"]) : AEDProgram = null;
		AEDPinCode = dr["AED_PinCode"] != DBNull.Value ? Convert.ToString(dr["AED_PinCode"]) : AEDPinCode = null;
		AEDLandLineNo = dr["AED_LandLineNo"] != DBNull.Value ? Convert.ToString(dr["AED_LandLineNo"]) : AEDLandLineNo = null;
		AEDMobileNo = dr["AED_MobileNo"] != DBNull.Value ? Convert.ToString(dr["AED_MobileNo"]) : AEDMobileNo = null;
		AEDEmailId = dr["AED_EmailId"] != DBNull.Value ? Convert.ToString(dr["AED_EmailId"]) : AEDEmailId = null;
		AEDAdminssionClass = dr["AED_AdminssionClass"] != DBNull.Value ? Convert.ToString(dr["AED_AdminssionClass"]) : AEDAdminssionClass = null;
		AEDPercentage = dr["AED_Percentage"] != DBNull.Value ? Convert.ToString(dr["AED_Percentage"]) : AEDPercentage = null;
		AEDCounsellorId = dr["AED_CounsellorId"] != DBNull.Value ? Convert.ToInt64(dr["AED_CounsellorId"]) : AEDCounsellorId = null;
		AEDRemark = dr["AED_Remark"] != DBNull.Value ? Convert.ToString(dr["AED_Remark"]) : AEDRemark = null;
		AEDComment = dr["AED_Comment"] != DBNull.Value ? Convert.ToString(dr["AED_Comment"]) : AEDComment = null;
		AEDDate = dr["AED_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AED_Date"]) : AEDDate = null;
		AEDStatus = dr["AED_Status"] != DBNull.Value ? Convert.ToInt32(dr["AED_Status"]) : AEDStatus = null;
	}
	
	public static TMSAdmissionEnquiryDetails[] MapFrom(DataSet ds)
	{
		List<TMSAdmissionEnquiryDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAdmissionEnquiryDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AdmissionEnquiryDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AdmissionEnquiryDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAdmissionEnquiryDetails instance = new TMSAdmissionEnquiryDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdmissionEnquiryDetails Get(System.Int64 aedEnquiryId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAdmissionEnquiryDetails instance;
		
		
		instance = new TMSAdmissionEnquiryDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aedEnquiryId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAdmissionEnquiryDetails ID:" + aedEnquiryId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String aedChildFirstName, System.String aedChildMiddleName, System.String aedChildLastName, System.DateTime? aedDateOfBirth, System.String aedGender, System.String aedGurdianName, System.String aedAddress, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedPinCode, System.String aedLandLineNo, System.String aedMobileNo, System.String aedEmailId, System.String aedAdminssionClass, System.String aedPercentage, System.Int64? aedCounsellorId, System.String aedRemark, System.String aedComment, System.DateTime? aedDate, System.Int32? aedStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aedChildFirstName, aedChildMiddleName, aedChildLastName, aedDateOfBirth, aedGender, aedGurdianName, aedAddress, aedCity, aedState, aedProgram, aedPinCode, aedLandLineNo, aedMobileNo, aedEmailId, aedAdminssionClass, aedPercentage, aedCounsellorId, aedRemark, aedComment, aedDate, aedStatus);
		
		if (transaction == null)
		this.AEDEnquiryId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.AEDEnquiryId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String aedChildFirstName, System.String aedChildMiddleName, System.String aedChildLastName, System.DateTime? aedDateOfBirth, System.String aedGender, System.String aedGurdianName, System.String aedAddress, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedPinCode, System.String aedLandLineNo, System.String aedMobileNo, System.String aedEmailId, System.String aedAdminssionClass, System.String aedPercentage, System.Int64? aedCounsellorId, System.String aedRemark, System.String aedComment, System.DateTime? aedDate, System.Int32? aedStatus)
	{
		Insert(aedChildFirstName, aedChildMiddleName, aedChildLastName, aedDateOfBirth, aedGender, aedGurdianName, aedAddress, aedCity, aedState, aedProgram, aedPinCode, aedLandLineNo, aedMobileNo, aedEmailId, aedAdminssionClass, aedPercentage, aedCounsellorId, aedRemark, aedComment, aedDate, aedStatus, null);
	}
	/// <summary>
	/// Insert current TMSAdmissionEnquiryDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(AEDChildFirstName, AEDChildMiddleName, AEDChildLastName, AEDDateOfBirth, AEDGender, AEDGurdianName, AEDAddress, AEDCity, AEDState, AEDProgram, AEDPinCode, AEDLandLineNo, AEDMobileNo, AEDEmailId, AEDAdminssionClass, AEDPercentage, AEDCounsellorId, AEDRemark, AEDComment, AEDDate, AEDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAdmissionEnquiryDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? aedEnquiryId, System.String aedChildFirstName, System.String aedChildMiddleName, System.String aedChildLastName, System.DateTime? aedDateOfBirth, System.String aedGender, System.String aedGurdianName, System.String aedAddress, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedPinCode, System.String aedLandLineNo, System.String aedMobileNo, System.String aedEmailId, System.String aedAdminssionClass, System.String aedPercentage, System.Int64? aedCounsellorId, System.String aedRemark, System.String aedComment, System.DateTime? aedDate, System.Int32? aedStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@aedEnquiryId"].Value = aedEnquiryId;
		dbCommand.Parameters["@aedChildFirstName"].Value = aedChildFirstName;
		dbCommand.Parameters["@aedChildMiddleName"].Value = aedChildMiddleName;
		dbCommand.Parameters["@aedChildLastName"].Value = aedChildLastName;
		dbCommand.Parameters["@aedDateOfBirth"].Value = aedDateOfBirth;
		dbCommand.Parameters["@aedGender"].Value = aedGender;
		dbCommand.Parameters["@aedGurdianName"].Value = aedGurdianName;
		dbCommand.Parameters["@aedAddress"].Value = aedAddress;
		dbCommand.Parameters["@aedCity"].Value = aedCity;
		dbCommand.Parameters["@aedState"].Value = aedState;
		dbCommand.Parameters["@aedProgram"].Value = aedProgram;
		dbCommand.Parameters["@aedPinCode"].Value = aedPinCode;
		dbCommand.Parameters["@aedLandLineNo"].Value = aedLandLineNo;
		dbCommand.Parameters["@aedMobileNo"].Value = aedMobileNo;
		dbCommand.Parameters["@aedEmailId"].Value = aedEmailId;
		dbCommand.Parameters["@aedAdminssionClass"].Value = aedAdminssionClass;
		dbCommand.Parameters["@aedPercentage"].Value = aedPercentage;
		dbCommand.Parameters["@aedCounsellorId"].Value = aedCounsellorId;
		dbCommand.Parameters["@aedRemark"].Value = aedRemark;
		dbCommand.Parameters["@aedComment"].Value = aedComment;
		dbCommand.Parameters["@aedDate"].Value = aedDate;
		dbCommand.Parameters["@aedStatus"].Value = aedStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? aedEnquiryId, System.String aedChildFirstName, System.String aedChildMiddleName, System.String aedChildLastName, System.DateTime? aedDateOfBirth, System.String aedGender, System.String aedGurdianName, System.String aedAddress, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedPinCode, System.String aedLandLineNo, System.String aedMobileNo, System.String aedEmailId, System.String aedAdminssionClass, System.String aedPercentage, System.Int64? aedCounsellorId, System.String aedRemark, System.String aedComment, System.DateTime? aedDate, System.Int32? aedStatus)
	{
		Update(aedEnquiryId, aedChildFirstName, aedChildMiddleName, aedChildLastName, aedDateOfBirth, aedGender, aedGurdianName, aedAddress, aedCity, aedState, aedProgram, aedPinCode, aedLandLineNo, aedMobileNo, aedEmailId, aedAdminssionClass, aedPercentage, aedCounsellorId, aedRemark, aedComment, aedDate, aedStatus, null);
	}
	
	public static void Update(TMSAdmissionEnquiryDetails tMSAdmissionEnquiryDetails)
	{
		tMSAdmissionEnquiryDetails.Update();
	}
	
	public static void Update(TMSAdmissionEnquiryDetails tMSAdmissionEnquiryDetails, DbTransaction transaction)
	{
		tMSAdmissionEnquiryDetails.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@aedEnquiryId"].SourceColumn = "AED_EnquiryId";
		dbCommand.Parameters["@aedChildFirstName"].SourceColumn = "AED_ChildFirstName";
		dbCommand.Parameters["@aedChildMiddleName"].SourceColumn = "AED_ChildMiddleName";
		dbCommand.Parameters["@aedChildLastName"].SourceColumn = "AED_ChildLastName";
		dbCommand.Parameters["@aedDateOfBirth"].SourceColumn = "AED_DateOfBirth";
		dbCommand.Parameters["@aedGender"].SourceColumn = "AED_Gender";
		dbCommand.Parameters["@aedGurdianName"].SourceColumn = "AED_GurdianName";
		dbCommand.Parameters["@aedAddress"].SourceColumn = "AED_Address";
		dbCommand.Parameters["@aedCity"].SourceColumn = "AED_City";
		dbCommand.Parameters["@aedState"].SourceColumn = "AED_State";
		dbCommand.Parameters["@aedProgram"].SourceColumn = "AED_Program";
		dbCommand.Parameters["@aedPinCode"].SourceColumn = "AED_PinCode";
		dbCommand.Parameters["@aedLandLineNo"].SourceColumn = "AED_LandLineNo";
		dbCommand.Parameters["@aedMobileNo"].SourceColumn = "AED_MobileNo";
		dbCommand.Parameters["@aedEmailId"].SourceColumn = "AED_EmailId";
		dbCommand.Parameters["@aedAdminssionClass"].SourceColumn = "AED_AdminssionClass";
		dbCommand.Parameters["@aedPercentage"].SourceColumn = "AED_Percentage";
		dbCommand.Parameters["@aedCounsellorId"].SourceColumn = "AED_CounsellorId";
		dbCommand.Parameters["@aedRemark"].SourceColumn = "AED_Remark";
		dbCommand.Parameters["@aedComment"].SourceColumn = "AED_Comment";
		dbCommand.Parameters["@aedDate"].SourceColumn = "AED_Date";
		dbCommand.Parameters["@aedStatus"].SourceColumn = "AED_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? aedEnquiryId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aedEnquiryId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? aedEnquiryId)
	{
		Delete(
		aedEnquiryId);
	}
	
	/// <summary>
	/// Delete current TMSAdmissionEnquiryDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, AEDEnquiryId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.AEDEnquiryId = null;
	}
	
	/// <summary>
	/// Delete current TMSAdmissionEnquiryDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdmissionEnquiryDetails[] Search(System.Int64? aedEnquiryId, System.String aedChildFirstName, System.String aedChildMiddleName, System.String aedChildLastName, System.DateTime? aedDateOfBirth, System.String aedGender, System.String aedGurdianName, System.String aedAddress, System.String aedCity, System.String aedState, System.String aedProgram, System.String aedPinCode, System.String aedLandLineNo, System.String aedMobileNo, System.String aedEmailId, System.String aedAdminssionClass, System.String aedPercentage, System.Int64? aedCounsellorId, System.String aedRemark, System.String aedComment, System.DateTime? aedDate, System.Int32? aedStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionEnquiryDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aedEnquiryId, aedChildFirstName, aedChildMiddleName, aedChildLastName, aedDateOfBirth, aedGender, aedGurdianName, aedAddress, aedCity, aedState, aedProgram, aedPinCode, aedLandLineNo, aedMobileNo, aedEmailId, aedAdminssionClass, aedPercentage, aedCounsellorId, aedRemark, aedComment, aedDate, aedStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAdmissionEnquiryDetails.MapFrom(ds);
	}
	
	
	public static TMSAdmissionEnquiryDetails[] Search(TMSAdmissionEnquiryDetails searchObject)
	{
		return Search ( searchObject.AEDEnquiryId, searchObject.AEDChildFirstName, searchObject.AEDChildMiddleName, searchObject.AEDChildLastName, searchObject.AEDDateOfBirth, searchObject.AEDGender, searchObject.AEDGurdianName, searchObject.AEDAddress, searchObject.AEDCity, searchObject.AEDState, searchObject.AEDProgram, searchObject.AEDPinCode, searchObject.AEDLandLineNo, searchObject.AEDMobileNo, searchObject.AEDEmailId, searchObject.AEDAdminssionClass, searchObject.AEDPercentage, searchObject.AEDCounsellorId, searchObject.AEDRemark, searchObject.AEDComment, searchObject.AEDDate, searchObject.AEDStatus);
	}
	
	/// <summary>
	/// Returns all TMSAdmissionEnquiryDetails objects.
	/// </summary>
	/// <returns>List of all TMSAdmissionEnquiryDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAdmissionEnquiryDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

