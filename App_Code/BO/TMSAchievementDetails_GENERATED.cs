/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/11/2012 4:40:23 PM                                    */
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
public partial class TMSAchievementDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AchievementDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adAchievementId;
	private System.Int64? _adStudentId;
	private System.Int64? _adFacultyId;
	private System.Int64? _adSchoolId;
	private System.Int64? _adSchoolSubId;
	private System.String _adTitle;
	private System.String _adDescription;
	private System.String _adImage;
	private System.DateTime? _adAchievementDate;
	private System.DateTime? _adDate;
	private System.Int32? _adStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADAchievementId
	{
		get
		{
			return _adAchievementId;
		}
		set
		{
			_adAchievementId = value;
		}
	}
	
	public System.Int64? ADStudentId
	{
		get
		{
			return _adStudentId;
		}
		set
		{
			_adStudentId = value;
		}
	}
	
	public System.Int64? ADFacultyId
	{
		get
		{
			return _adFacultyId;
		}
		set
		{
			_adFacultyId = value;
		}
	}
	
	public System.Int64? ADSchoolId
	{
		get
		{
			return _adSchoolId;
		}
		set
		{
			_adSchoolId = value;
		}
	}
	
	public System.Int64? ADSchoolSubId
	{
		get
		{
			return _adSchoolSubId;
		}
		set
		{
			_adSchoolSubId = value;
		}
	}
	
	public System.String ADTitle
	{
		get
		{
			return _adTitle;
		}
		set
		{
			_adTitle = value;
		}
	}
	
	public System.String ADDescription
	{
		get
		{
			return _adDescription;
		}
		set
		{
			_adDescription = value;
		}
	}
	
	public System.String ADImage
	{
		get
		{
			return _adImage;
		}
		set
		{
			_adImage = value;
		}
	}
	
	public System.DateTime? ADAchievementDate
	{
		get
		{
			return _adAchievementDate;
		}
		set
		{
			_adAchievementDate = value;
		}
	}
	
	public System.DateTime? ADDate
	{
		get
		{
			return _adDate;
		}
		set
		{
			_adDate = value;
		}
	}
	
	public System.Int32? ADStatus
	{
		get
		{
			return _adStatus;
		}
		set
		{
			_adStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_AchievementId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_AchievementDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADAchievementId == null)
		dr["AD_AchievementId"] = DBNull.Value;
		else
		dr["AD_AchievementId"] = ADAchievementId;
		
		if (ADStudentId == null)
		dr["AD_StudentId"] = DBNull.Value;
		else
		dr["AD_StudentId"] = ADStudentId;
		
		if (ADFacultyId == null)
		dr["AD_FacultyId"] = DBNull.Value;
		else
		dr["AD_FacultyId"] = ADFacultyId;
		
		if (ADSchoolId == null)
		dr["AD_SchoolId"] = DBNull.Value;
		else
		dr["AD_SchoolId"] = ADSchoolId;
		
		if (ADSchoolSubId == null)
		dr["AD_SchoolSubId"] = DBNull.Value;
		else
		dr["AD_SchoolSubId"] = ADSchoolSubId;
		
		if (ADTitle == null)
		dr["AD_Title"] = DBNull.Value;
		else
		dr["AD_Title"] = ADTitle;
		
		if (ADDescription == null)
		dr["AD_Description"] = DBNull.Value;
		else
		dr["AD_Description"] = ADDescription;
		
		if (ADImage == null)
		dr["AD_Image"] = DBNull.Value;
		else
		dr["AD_Image"] = ADImage;
		
		if (ADAchievementDate == null)
		dr["AD_AchievementDate"] = DBNull.Value;
		else
		dr["AD_AchievementDate"] = ADAchievementDate;
		
		if (ADDate == null)
		dr["AD_Date"] = DBNull.Value;
		else
		dr["AD_Date"] = ADDate;
		
		if (ADStatus == null)
		dr["AD_Status"] = DBNull.Value;
		else
		dr["AD_Status"] = ADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ADAchievementId = dr["AD_AchievementId"] != DBNull.Value ? Convert.ToInt64(dr["AD_AchievementId"]) : ADAchievementId = null;
		ADStudentId = dr["AD_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["AD_StudentId"]) : ADStudentId = null;
		ADFacultyId = dr["AD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["AD_FacultyId"]) : ADFacultyId = null;
		ADSchoolId = dr["AD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["AD_SchoolId"]) : ADSchoolId = null;
		ADSchoolSubId = dr["AD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["AD_SchoolSubId"]) : ADSchoolSubId = null;
		ADTitle = dr["AD_Title"] != DBNull.Value ? Convert.ToString(dr["AD_Title"]) : ADTitle = null;
		ADDescription = dr["AD_Description"] != DBNull.Value ? Convert.ToString(dr["AD_Description"]) : ADDescription = null;
		ADImage = dr["AD_Image"] != DBNull.Value ? Convert.ToString(dr["AD_Image"]) : ADImage = null;
		ADAchievementDate = dr["AD_AchievementDate"] != DBNull.Value ? Convert.ToDateTime(dr["AD_AchievementDate"]) : ADAchievementDate = null;
		ADDate = dr["AD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AD_Date"]) : ADDate = null;
		ADStatus = dr["AD_Status"] != DBNull.Value ? Convert.ToInt32(dr["AD_Status"]) : ADStatus = null;
	}
	
	public static TMSAchievementDetails[] MapFrom(DataSet ds)
	{
		List<TMSAchievementDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAchievementDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AchievementDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AchievementDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAchievementDetails instance = new TMSAchievementDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAchievementDetails Get(System.Int64 adAchievementId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAchievementDetails instance;
		
		
		instance = new TMSAchievementDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAchievementDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAchievementId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAchievementDetails ID:" + adAchievementId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? adStudentId, System.Int64? adFacultyId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adTitle, System.String adDescription, System.String adImage, System.DateTime? adAchievementDate, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAchievementDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adStudentId, adFacultyId, adSchoolId, adSchoolSubId, adTitle, adDescription, adImage, adAchievementDate, adDate, adStatus);
		
		if (transaction == null)
		this.ADAchievementId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADAchievementId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? adStudentId, System.Int64? adFacultyId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adTitle, System.String adDescription, System.String adImage, System.DateTime? adAchievementDate, System.DateTime? adDate, System.Int32? adStatus)
	{
		Insert(adStudentId, adFacultyId, adSchoolId, adSchoolSubId, adTitle, adDescription, adImage, adAchievementDate, adDate, adStatus, null);
	}
	/// <summary>
	/// Insert current TMSAchievementDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADStudentId, ADFacultyId, ADSchoolId, ADSchoolSubId, ADTitle, ADDescription, ADImage, ADAchievementDate, ADDate, ADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAchievementDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adAchievementId, System.Int64? adStudentId, System.Int64? adFacultyId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adTitle, System.String adDescription, System.String adImage, System.DateTime? adAchievementDate, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAchievementDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adAchievementId"].Value = adAchievementId;
		dbCommand.Parameters["@adStudentId"].Value = adStudentId;
		dbCommand.Parameters["@adFacultyId"].Value = adFacultyId;
		dbCommand.Parameters["@adSchoolId"].Value = adSchoolId;
		dbCommand.Parameters["@adSchoolSubId"].Value = adSchoolSubId;
		dbCommand.Parameters["@adTitle"].Value = adTitle;
		dbCommand.Parameters["@adDescription"].Value = adDescription;
		dbCommand.Parameters["@adImage"].Value = adImage;
		dbCommand.Parameters["@adAchievementDate"].Value = adAchievementDate;
		dbCommand.Parameters["@adDate"].Value = adDate;
		dbCommand.Parameters["@adStatus"].Value = adStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adAchievementId, System.Int64? adStudentId, System.Int64? adFacultyId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adTitle, System.String adDescription, System.String adImage, System.DateTime? adAchievementDate, System.DateTime? adDate, System.Int32? adStatus)
	{
		Update(adAchievementId, adStudentId, adFacultyId, adSchoolId, adSchoolSubId, adTitle, adDescription, adImage, adAchievementDate, adDate, adStatus, null);
	}
	
	public static void Update(TMSAchievementDetails tMSAchievementDetails)
	{
		tMSAchievementDetails.Update();
	}
	
	public static void Update(TMSAchievementDetails tMSAchievementDetails, DbTransaction transaction)
	{
		tMSAchievementDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAchievementDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adAchievementId"].SourceColumn = "AD_AchievementId";
		dbCommand.Parameters["@adStudentId"].SourceColumn = "AD_StudentId";
		dbCommand.Parameters["@adFacultyId"].SourceColumn = "AD_FacultyId";
		dbCommand.Parameters["@adSchoolId"].SourceColumn = "AD_SchoolId";
		dbCommand.Parameters["@adSchoolSubId"].SourceColumn = "AD_SchoolSubId";
		dbCommand.Parameters["@adTitle"].SourceColumn = "AD_Title";
		dbCommand.Parameters["@adDescription"].SourceColumn = "AD_Description";
		dbCommand.Parameters["@adImage"].SourceColumn = "AD_Image";
		dbCommand.Parameters["@adAchievementDate"].SourceColumn = "AD_AchievementDate";
		dbCommand.Parameters["@adDate"].SourceColumn = "AD_Date";
		dbCommand.Parameters["@adStatus"].SourceColumn = "AD_Status";
		
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
	public static void Delete(System.Int64? adAchievementId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAchievementDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAchievementId);
		
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
	public static void Delete(System.Int64? adAchievementId)
	{
		Delete(
		adAchievementId);
	}
	
	/// <summary>
	/// Delete current TMSAchievementDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAchievementDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADAchievementId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADAchievementId = null;
	}
	
	/// <summary>
	/// Delete current TMSAchievementDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAchievementDetails[] Search(System.Int64? adAchievementId, System.Int64? adStudentId, System.Int64? adFacultyId, System.Int64? adSchoolId, System.Int64? adSchoolSubId, System.String adTitle, System.String adDescription, System.String adImage, System.DateTime? adAchievementDate, System.DateTime? adDate, System.Int32? adStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAchievementDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAchievementId, adStudentId, adFacultyId, adSchoolId, adSchoolSubId, adTitle, adDescription, adImage, adAchievementDate, adDate, adStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAchievementDetails.MapFrom(ds);
	}
	
	
	public static TMSAchievementDetails[] Search(TMSAchievementDetails searchObject)
	{
		return Search ( searchObject.ADAchievementId, searchObject.ADStudentId, searchObject.ADFacultyId, searchObject.ADSchoolId, searchObject.ADSchoolSubId, searchObject.ADTitle, searchObject.ADDescription, searchObject.ADImage, searchObject.ADAchievementDate, searchObject.ADDate, searchObject.ADStatus);
	}
	
	/// <summary>
	/// Returns all TMSAchievementDetails objects.
	/// </summary>
	/// <returns>List of all TMSAchievementDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAchievementDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

