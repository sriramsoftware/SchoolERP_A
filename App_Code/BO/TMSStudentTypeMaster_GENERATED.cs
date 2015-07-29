/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 20/07/2015 10:36:51 PM                                    */
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
public partial class TMSStudentTypeMaster
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_StudentTypeMaster]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _studentTypeID;
	private System.Int32? _feeCategoryID;
	private System.String _studentTypeName;
	private System.DateTime? _createdDate;
	private System.Boolean? _isDelete;
	
	#endregion
	
	
	#region Properties
	public System.Int32? StudentTypeID
	{
		get
		{
			return _studentTypeID;
		}
		set
		{
			_studentTypeID = value;
		}
	}
	
	public System.Int32? FeeCategoryID
	{
		get
		{
			return _feeCategoryID;
		}
		set
		{
			_feeCategoryID = value;
		}
	}
	
	public System.String StudentTypeName
	{
		get
		{
			return _studentTypeName;
		}
		set
		{
			_studentTypeName = value;
		}
	}
	
	public System.DateTime? CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}
	
	public System.Boolean? IsDelete
	{
		get
		{
			return _isDelete;
		}
		set
		{
			_isDelete = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("StudentTypeID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeeCategoryID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("StudentTypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CreatedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("IsDelete", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (StudentTypeID == null)
		dr["StudentTypeID"] = DBNull.Value;
		else
		dr["StudentTypeID"] = StudentTypeID;
		
		if (FeeCategoryID == null)
		dr["FeeCategoryID"] = DBNull.Value;
		else
		dr["FeeCategoryID"] = FeeCategoryID;
		
		if (StudentTypeName == null)
		dr["StudentTypeName"] = DBNull.Value;
		else
		dr["StudentTypeName"] = StudentTypeName;
		
		if (CreatedDate == null)
		dr["CreatedDate"] = DBNull.Value;
		else
		dr["CreatedDate"] = CreatedDate;
		
		if (IsDelete == null)
		dr["IsDelete"] = DBNull.Value;
		else
		dr["IsDelete"] = IsDelete;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		StudentTypeID = dr["StudentTypeID"] != DBNull.Value ? Convert.ToInt32(dr["StudentTypeID"]) : StudentTypeID = null;
		FeeCategoryID = dr["FeeCategoryID"] != DBNull.Value ? Convert.ToInt32(dr["FeeCategoryID"]) : FeeCategoryID = null;
		StudentTypeName = dr["StudentTypeName"] != DBNull.Value ? Convert.ToString(dr["StudentTypeName"]) : StudentTypeName = null;
		CreatedDate = dr["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(dr["CreatedDate"]) : CreatedDate = null;
		IsDelete = dr["IsDelete"] != DBNull.Value ? Convert.ToBoolean(dr["IsDelete"]) : IsDelete = null;
	}
	
	public static TMSStudentTypeMaster[] MapFrom(DataSet ds)
	{
		List<TMSStudentTypeMaster> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSStudentTypeMaster>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_StudentTypeMaster] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_StudentTypeMaster] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSStudentTypeMaster instance = new TMSStudentTypeMaster();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSStudentTypeMaster Get(System.Int32 studentTypeID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSStudentTypeMaster instance;
		
		
		instance = new TMSStudentTypeMaster();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, studentTypeID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSStudentTypeMaster ID:" + studentTypeID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? feeCategoryID, System.String studentTypeName, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryID, studentTypeName, createdDate, isDelete);
		
		if (transaction == null)
		this.StudentTypeID = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.StudentTypeID = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? feeCategoryID, System.String studentTypeName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Insert(feeCategoryID, studentTypeName, createdDate, isDelete, null);
	}
	/// <summary>
	/// Insert current TMSStudentTypeMaster to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FeeCategoryID, StudentTypeName, CreatedDate, IsDelete, transaction);
	}
	
	/// <summary>
	/// Insert current TMSStudentTypeMaster to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? studentTypeID, System.Int32? feeCategoryID, System.String studentTypeName, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@studentTypeID"].Value = studentTypeID;
		dbCommand.Parameters["@feeCategoryID"].Value = feeCategoryID;
		dbCommand.Parameters["@studentTypeName"].Value = studentTypeName;
		dbCommand.Parameters["@createdDate"].Value = createdDate;
		dbCommand.Parameters["@isDelete"].Value = isDelete;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? studentTypeID, System.Int32? feeCategoryID, System.String studentTypeName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Update(studentTypeID, feeCategoryID, studentTypeName, createdDate, isDelete, null);
	}
	
	public static void Update(TMSStudentTypeMaster tMSStudentTypeMaster)
	{
		tMSStudentTypeMaster.Update();
	}
	
	public static void Update(TMSStudentTypeMaster tMSStudentTypeMaster, DbTransaction transaction)
	{
		tMSStudentTypeMaster.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@studentTypeID"].SourceColumn = "StudentTypeID";
		dbCommand.Parameters["@feeCategoryID"].SourceColumn = "FeeCategoryID";
		dbCommand.Parameters["@studentTypeName"].SourceColumn = "StudentTypeName";
		dbCommand.Parameters["@createdDate"].SourceColumn = "CreatedDate";
		dbCommand.Parameters["@isDelete"].SourceColumn = "IsDelete";
		
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
	public static void Delete(System.Int32? studentTypeID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, studentTypeID);
		
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
	public static void Delete(System.Int32? studentTypeID)
	{
		Delete(
		studentTypeID);
	}
	
	/// <summary>
	/// Delete current TMSStudentTypeMaster from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, StudentTypeID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.StudentTypeID = null;
	}
	
	/// <summary>
	/// Delete current TMSStudentTypeMaster from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSStudentTypeMaster[] Search(System.Int32? studentTypeID, System.Int32? feeCategoryID, System.String studentTypeName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSStudentTypeMaster_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, studentTypeID, feeCategoryID, studentTypeName, createdDate, isDelete);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSStudentTypeMaster.MapFrom(ds);
	}
	
	
	public static TMSStudentTypeMaster[] Search(TMSStudentTypeMaster searchObject)
	{
		return Search ( searchObject.StudentTypeID, searchObject.FeeCategoryID, searchObject.StudentTypeName, searchObject.CreatedDate, searchObject.IsDelete);
	}
	
	/// <summary>
	/// Returns all TMSStudentTypeMaster objects.
	/// </summary>
	/// <returns>List of all TMSStudentTypeMaster objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSStudentTypeMaster[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

