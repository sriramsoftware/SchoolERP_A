/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/14/2012 12:12:21 PM                                    */
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
public partial class TMSClassAssignFacultyDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ClassAssignFacultyDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _cafdAssignId;
	private System.Int64? _cafdFacultyId;
	private System.Int64? _cafdSchoolId;
	private System.Int64? _cafdSchoolSubCategoryId;
	private System.Int64? _cafdDepartmentId;
	private System.Int64? _cafdSubjectId;
	private System.String _cafdAssignType;
	private System.DateTime? _cafdDate;
	private System.Int32? _cafdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CAFDAssignId
	{
		get
		{
			return _cafdAssignId;
		}
		set
		{
			_cafdAssignId = value;
		}
	}
	
	public System.Int64? CAFDFacultyId
	{
		get
		{
			return _cafdFacultyId;
		}
		set
		{
			_cafdFacultyId = value;
		}
	}
	
	public System.Int64? CAFDSchoolId
	{
		get
		{
			return _cafdSchoolId;
		}
		set
		{
			_cafdSchoolId = value;
		}
	}
	
	public System.Int64? CAFDSchoolSubCategoryId
	{
		get
		{
			return _cafdSchoolSubCategoryId;
		}
		set
		{
			_cafdSchoolSubCategoryId = value;
		}
	}
	
	public System.Int64? CAFDDepartmentId
	{
		get
		{
			return _cafdDepartmentId;
		}
		set
		{
			_cafdDepartmentId = value;
		}
	}
	
	public System.Int64? CAFDSubjectId
	{
		get
		{
			return _cafdSubjectId;
		}
		set
		{
			_cafdSubjectId = value;
		}
	}
	
	public System.String CAFDAssignType
	{
		get
		{
			return _cafdAssignType;
		}
		set
		{
			_cafdAssignType = value;
		}
	}
	
	public System.DateTime? CAFDDate
	{
		get
		{
			return _cafdDate;
		}
		set
		{
			_cafdDate = value;
		}
	}
	
	public System.Int32? CAFDStatus
	{
		get
		{
			return _cafdStatus;
		}
		set
		{
			_cafdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_AssignId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_SchoolSubCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_DepartmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_AssignType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CAFD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CAFDAssignId == null)
		dr["CAFD_AssignId"] = DBNull.Value;
		else
		dr["CAFD_AssignId"] = CAFDAssignId;
		
		if (CAFDFacultyId == null)
		dr["CAFD_FacultyId"] = DBNull.Value;
		else
		dr["CAFD_FacultyId"] = CAFDFacultyId;
		
		if (CAFDSchoolId == null)
		dr["CAFD_SchoolId"] = DBNull.Value;
		else
		dr["CAFD_SchoolId"] = CAFDSchoolId;
		
		if (CAFDSchoolSubCategoryId == null)
		dr["CAFD_SchoolSubCategoryId"] = DBNull.Value;
		else
		dr["CAFD_SchoolSubCategoryId"] = CAFDSchoolSubCategoryId;
		
		if (CAFDDepartmentId == null)
		dr["CAFD_DepartmentId"] = DBNull.Value;
		else
		dr["CAFD_DepartmentId"] = CAFDDepartmentId;
		
		if (CAFDSubjectId == null)
		dr["CAFD_SubjectId"] = DBNull.Value;
		else
		dr["CAFD_SubjectId"] = CAFDSubjectId;
		
		if (CAFDAssignType == null)
		dr["CAFD_AssignType"] = DBNull.Value;
		else
		dr["CAFD_AssignType"] = CAFDAssignType;
		
		if (CAFDDate == null)
		dr["CAFD_Date"] = DBNull.Value;
		else
		dr["CAFD_Date"] = CAFDDate;
		
		if (CAFDStatus == null)
		dr["CAFD_Status"] = DBNull.Value;
		else
		dr["CAFD_Status"] = CAFDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CAFDAssignId = dr["CAFD_AssignId"] != DBNull.Value ? Convert.ToInt64(dr["CAFD_AssignId"]) : CAFDAssignId = null;
		CAFDFacultyId = dr["CAFD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["CAFD_FacultyId"]) : CAFDFacultyId = null;
		CAFDSchoolId = dr["CAFD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["CAFD_SchoolId"]) : CAFDSchoolId = null;
		CAFDSchoolSubCategoryId = dr["CAFD_SchoolSubCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["CAFD_SchoolSubCategoryId"]) : CAFDSchoolSubCategoryId = null;
		CAFDDepartmentId = dr["CAFD_DepartmentId"] != DBNull.Value ? Convert.ToInt64(dr["CAFD_DepartmentId"]) : CAFDDepartmentId = null;
		CAFDSubjectId = dr["CAFD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["CAFD_SubjectId"]) : CAFDSubjectId = null;
		CAFDAssignType = dr["CAFD_AssignType"] != DBNull.Value ? Convert.ToString(dr["CAFD_AssignType"]) : CAFDAssignType = null;
		CAFDDate = dr["CAFD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["CAFD_Date"]) : CAFDDate = null;
		CAFDStatus = dr["CAFD_Status"] != DBNull.Value ? Convert.ToInt32(dr["CAFD_Status"]) : CAFDStatus = null;
	}
	
	public static TMSClassAssignFacultyDetails[] MapFrom(DataSet ds)
	{
		List<TMSClassAssignFacultyDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSClassAssignFacultyDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ClassAssignFacultyDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ClassAssignFacultyDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSClassAssignFacultyDetails instance = new TMSClassAssignFacultyDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSClassAssignFacultyDetails Get(System.Int64 cafdAssignId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSClassAssignFacultyDetails instance;
		
		
		instance = new TMSClassAssignFacultyDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cafdAssignId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSClassAssignFacultyDetails ID:" + cafdAssignId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? cafdFacultyId, System.Int64? cafdSchoolId, System.Int64? cafdSchoolSubCategoryId, System.Int64? cafdDepartmentId, System.Int64? cafdSubjectId, System.String cafdAssignType, System.DateTime? cafdDate, System.Int32? cafdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cafdFacultyId, cafdSchoolId, cafdSchoolSubCategoryId, cafdDepartmentId, cafdSubjectId, cafdAssignType, cafdDate, cafdStatus);
		
		if (transaction == null)
		this.CAFDAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CAFDAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? cafdFacultyId, System.Int64? cafdSchoolId, System.Int64? cafdSchoolSubCategoryId, System.Int64? cafdDepartmentId, System.Int64? cafdSubjectId, System.String cafdAssignType, System.DateTime? cafdDate, System.Int32? cafdStatus)
	{
		Insert(cafdFacultyId, cafdSchoolId, cafdSchoolSubCategoryId, cafdDepartmentId, cafdSubjectId, cafdAssignType, cafdDate, cafdStatus, null);
	}
	/// <summary>
	/// Insert current TMSClassAssignFacultyDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CAFDFacultyId, CAFDSchoolId, CAFDSchoolSubCategoryId, CAFDDepartmentId, CAFDSubjectId, CAFDAssignType, CAFDDate, CAFDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSClassAssignFacultyDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? cafdAssignId, System.Int64? cafdFacultyId, System.Int64? cafdSchoolId, System.Int64? cafdSchoolSubCategoryId, System.Int64? cafdDepartmentId, System.Int64? cafdSubjectId, System.String cafdAssignType, System.DateTime? cafdDate, System.Int32? cafdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cafdAssignId"].Value = cafdAssignId;
		dbCommand.Parameters["@cafdFacultyId"].Value = cafdFacultyId;
		dbCommand.Parameters["@cafdSchoolId"].Value = cafdSchoolId;
		dbCommand.Parameters["@cafdSchoolSubCategoryId"].Value = cafdSchoolSubCategoryId;
		dbCommand.Parameters["@cafdDepartmentId"].Value = cafdDepartmentId;
		dbCommand.Parameters["@cafdSubjectId"].Value = cafdSubjectId;
		dbCommand.Parameters["@cafdAssignType"].Value = cafdAssignType;
		dbCommand.Parameters["@cafdDate"].Value = cafdDate;
		dbCommand.Parameters["@cafdStatus"].Value = cafdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? cafdAssignId, System.Int64? cafdFacultyId, System.Int64? cafdSchoolId, System.Int64? cafdSchoolSubCategoryId, System.Int64? cafdDepartmentId, System.Int64? cafdSubjectId, System.String cafdAssignType, System.DateTime? cafdDate, System.Int32? cafdStatus)
	{
		Update(cafdAssignId, cafdFacultyId, cafdSchoolId, cafdSchoolSubCategoryId, cafdDepartmentId, cafdSubjectId, cafdAssignType, cafdDate, cafdStatus, null);
	}
	
	public static void Update(TMSClassAssignFacultyDetails tMSClassAssignFacultyDetails)
	{
		tMSClassAssignFacultyDetails.Update();
	}
	
	public static void Update(TMSClassAssignFacultyDetails tMSClassAssignFacultyDetails, DbTransaction transaction)
	{
		tMSClassAssignFacultyDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cafdAssignId"].SourceColumn = "CAFD_AssignId";
		dbCommand.Parameters["@cafdFacultyId"].SourceColumn = "CAFD_FacultyId";
		dbCommand.Parameters["@cafdSchoolId"].SourceColumn = "CAFD_SchoolId";
		dbCommand.Parameters["@cafdSchoolSubCategoryId"].SourceColumn = "CAFD_SchoolSubCategoryId";
		dbCommand.Parameters["@cafdDepartmentId"].SourceColumn = "CAFD_DepartmentId";
		dbCommand.Parameters["@cafdSubjectId"].SourceColumn = "CAFD_SubjectId";
		dbCommand.Parameters["@cafdAssignType"].SourceColumn = "CAFD_AssignType";
		dbCommand.Parameters["@cafdDate"].SourceColumn = "CAFD_Date";
		dbCommand.Parameters["@cafdStatus"].SourceColumn = "CAFD_Status";
		
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
	public static void Delete(System.Int64? cafdAssignId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cafdAssignId);
		
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
	public static void Delete(System.Int64? cafdAssignId)
	{
		Delete(
		cafdAssignId);
	}
	
	/// <summary>
	/// Delete current TMSClassAssignFacultyDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CAFDAssignId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CAFDAssignId = null;
	}
	
	/// <summary>
	/// Delete current TMSClassAssignFacultyDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSClassAssignFacultyDetails[] Search(System.Int64? cafdAssignId, System.Int64? cafdFacultyId, System.Int64? cafdSchoolId, System.Int64? cafdSchoolSubCategoryId, System.Int64? cafdDepartmentId, System.Int64? cafdSubjectId, System.String cafdAssignType, System.DateTime? cafdDate, System.Int32? cafdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassAssignFacultyDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cafdAssignId, cafdFacultyId, cafdSchoolId, cafdSchoolSubCategoryId, cafdDepartmentId, cafdSubjectId, cafdAssignType, cafdDate, cafdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSClassAssignFacultyDetails.MapFrom(ds);
	}
	
	
	public static TMSClassAssignFacultyDetails[] Search(TMSClassAssignFacultyDetails searchObject)
	{
		return Search ( searchObject.CAFDAssignId, searchObject.CAFDFacultyId, searchObject.CAFDSchoolId, searchObject.CAFDSchoolSubCategoryId, searchObject.CAFDDepartmentId, searchObject.CAFDSubjectId, searchObject.CAFDAssignType, searchObject.CAFDDate, searchObject.CAFDStatus);
	}
	
	/// <summary>
	/// Returns all TMSClassAssignFacultyDetails objects.
	/// </summary>
	/// <returns>List of all TMSClassAssignFacultyDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSClassAssignFacultyDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

