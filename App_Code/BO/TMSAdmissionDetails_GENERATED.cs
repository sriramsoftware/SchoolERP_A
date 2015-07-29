/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSAdmissionDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AdmissionDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adAdmissionId;
	private System.Int64? _adSchoolCategoryId;
	private System.Int64? _adSchoolSubCatId;
	private System.String _adDetails;
	private System.DateTime? _adDate;
	private System.Int32? _adStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADAdmissionId
	{
		get
		{
			return _adAdmissionId;
		}
		set
		{
			_adAdmissionId = value;
		}
	}
	
	public System.Int64? ADSchoolCategoryId
	{
		get
		{
			return _adSchoolCategoryId;
		}
		set
		{
			_adSchoolCategoryId = value;
		}
	}
	
	public System.Int64? ADSchoolSubCatId
	{
		get
		{
			return _adSchoolSubCatId;
		}
		set
		{
			_adSchoolSubCatId = value;
		}
	}
	
	public System.String ADDetails
	{
		get
		{
			return _adDetails;
		}
		set
		{
			_adDetails = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_AdmissionId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SchoolCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SchoolSubCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Details", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADAdmissionId == null)
		dr["AD_AdmissionId"] = DBNull.Value;
		else
		dr["AD_AdmissionId"] = ADAdmissionId;
		
		if (ADSchoolCategoryId == null)
		dr["AD_SchoolCategoryId"] = DBNull.Value;
		else
		dr["AD_SchoolCategoryId"] = ADSchoolCategoryId;
		
		if (ADSchoolSubCatId == null)
		dr["AD_SchoolSubCatId"] = DBNull.Value;
		else
		dr["AD_SchoolSubCatId"] = ADSchoolSubCatId;
		
		if (ADDetails == null)
		dr["AD_Details"] = DBNull.Value;
		else
		dr["AD_Details"] = ADDetails;
		
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
		ADAdmissionId = dr["AD_AdmissionId"] != DBNull.Value ? Convert.ToInt64(dr["AD_AdmissionId"]) : ADAdmissionId = null;
		ADSchoolCategoryId = dr["AD_SchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["AD_SchoolCategoryId"]) : ADSchoolCategoryId = null;
		ADSchoolSubCatId = dr["AD_SchoolSubCatId"] != DBNull.Value ? Convert.ToInt64(dr["AD_SchoolSubCatId"]) : ADSchoolSubCatId = null;
		ADDetails = dr["AD_Details"] != DBNull.Value ? Convert.ToString(dr["AD_Details"]) : ADDetails = null;
		ADDate = dr["AD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AD_Date"]) : ADDate = null;
		ADStatus = dr["AD_Status"] != DBNull.Value ? Convert.ToInt32(dr["AD_Status"]) : ADStatus = null;
	}
	
	public static TMSAdmissionDetails[] MapFrom(DataSet ds)
	{
		List<TMSAdmissionDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAdmissionDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AdmissionDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AdmissionDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAdmissionDetails instance = new TMSAdmissionDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdmissionDetails Get(System.Int64 adAdmissionId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAdmissionDetails instance;
		
		
		instance = new TMSAdmissionDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAdmissionId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAdmissionDetails ID:" + adAdmissionId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? adSchoolCategoryId, System.Int64? adSchoolSubCatId, System.String adDetails, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adSchoolCategoryId, adSchoolSubCatId, adDetails, adDate, adStatus);
		
		if (transaction == null)
		this.ADAdmissionId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADAdmissionId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? adSchoolCategoryId, System.Int64? adSchoolSubCatId, System.String adDetails, System.DateTime? adDate, System.Int32? adStatus)
	{
		Insert(adSchoolCategoryId, adSchoolSubCatId, adDetails, adDate, adStatus, null);
	}
	/// <summary>
	/// Insert current TMSAdmissionDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADSchoolCategoryId, ADSchoolSubCatId, ADDetails, ADDate, ADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAdmissionDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adAdmissionId, System.Int64? adSchoolCategoryId, System.Int64? adSchoolSubCatId, System.String adDetails, System.DateTime? adDate, System.Int32? adStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adAdmissionId"].Value = adAdmissionId;
		dbCommand.Parameters["@adSchoolCategoryId"].Value = adSchoolCategoryId;
		dbCommand.Parameters["@adSchoolSubCatId"].Value = adSchoolSubCatId;
		dbCommand.Parameters["@adDetails"].Value = adDetails;
		dbCommand.Parameters["@adDate"].Value = adDate;
		dbCommand.Parameters["@adStatus"].Value = adStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adAdmissionId, System.Int64? adSchoolCategoryId, System.Int64? adSchoolSubCatId, System.String adDetails, System.DateTime? adDate, System.Int32? adStatus)
	{
		Update(adAdmissionId, adSchoolCategoryId, adSchoolSubCatId, adDetails, adDate, adStatus, null);
	}
	
	public static void Update(TMSAdmissionDetails tMSAdmissionDetails)
	{
		tMSAdmissionDetails.Update();
	}
	
	public static void Update(TMSAdmissionDetails tMSAdmissionDetails, DbTransaction transaction)
	{
		tMSAdmissionDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAdmissionDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adAdmissionId"].SourceColumn = "AD_AdmissionId";
		dbCommand.Parameters["@adSchoolCategoryId"].SourceColumn = "AD_SchoolCategoryId";
		dbCommand.Parameters["@adSchoolSubCatId"].SourceColumn = "AD_SchoolSubCatId";
		dbCommand.Parameters["@adDetails"].SourceColumn = "AD_Details";
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
	public static void Delete(System.Int64? adAdmissionId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAdmissionId);
		
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
	public static void Delete(System.Int64? adAdmissionId)
	{
		Delete(
		adAdmissionId);
	}
	
	/// <summary>
	/// Delete current TMSAdmissionDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADAdmissionId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADAdmissionId = null;
	}
	
	/// <summary>
	/// Delete current TMSAdmissionDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdmissionDetails[] Search(System.Int64? adAdmissionId, System.Int64? adSchoolCategoryId, System.Int64? adSchoolSubCatId, System.String adDetails, System.DateTime? adDate, System.Int32? adStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdmissionDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAdmissionId, adSchoolCategoryId, adSchoolSubCatId, adDetails, adDate, adStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAdmissionDetails.MapFrom(ds);
	}
	
	
	public static TMSAdmissionDetails[] Search(TMSAdmissionDetails searchObject)
	{
		return Search ( searchObject.ADAdmissionId, searchObject.ADSchoolCategoryId, searchObject.ADSchoolSubCatId, searchObject.ADDetails, searchObject.ADDate, searchObject.ADStatus);
	}
	
	/// <summary>
	/// Returns all TMSAdmissionDetails objects.
	/// </summary>
	/// <returns>List of all TMSAdmissionDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAdmissionDetails[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

