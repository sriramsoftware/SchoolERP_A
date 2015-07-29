/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/22/2012 3:38:23 PM                                    */
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
public partial class TMSDownloadBroucher
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_DownloadBroucher]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _dbBroucherID;
	private System.String _dbName;
	private System.String _dbContactno;
	private System.String _dbEmailID;
	private System.String _dbDescription;
	private System.String _dbSchoolName;
	private System.String _dbStaticID;
	private System.String _dbPhysicalID;
	private System.String _dbCountryName;
	private System.String _dbMiniBroucher;
	private System.String _dbExtra1;
	private System.String _dbExtra2;
	private System.DateTime? _dbDate;
	private System.Int32? _dbStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? DBBroucherID
	{
		get
		{
			return _dbBroucherID;
		}
		set
		{
			_dbBroucherID = value;
		}
	}
	
	public System.String DBName
	{
		get
		{
			return _dbName;
		}
		set
		{
			_dbName = value;
		}
	}
	
	public System.String DBContactno
	{
		get
		{
			return _dbContactno;
		}
		set
		{
			_dbContactno = value;
		}
	}
	
	public System.String DBEmailID
	{
		get
		{
			return _dbEmailID;
		}
		set
		{
			_dbEmailID = value;
		}
	}
	
	public System.String DBDescription
	{
		get
		{
			return _dbDescription;
		}
		set
		{
			_dbDescription = value;
		}
	}
	
	public System.String DBSchoolName
	{
		get
		{
			return _dbSchoolName;
		}
		set
		{
			_dbSchoolName = value;
		}
	}
	
	public System.String DBStaticID
	{
		get
		{
			return _dbStaticID;
		}
		set
		{
			_dbStaticID = value;
		}
	}
	
	public System.String DBPhysicalID
	{
		get
		{
			return _dbPhysicalID;
		}
		set
		{
			_dbPhysicalID = value;
		}
	}
	
	public System.String DBCountryName
	{
		get
		{
			return _dbCountryName;
		}
		set
		{
			_dbCountryName = value;
		}
	}
	
	public System.String DBMiniBroucher
	{
		get
		{
			return _dbMiniBroucher;
		}
		set
		{
			_dbMiniBroucher = value;
		}
	}
	
	public System.String DBExtra1
	{
		get
		{
			return _dbExtra1;
		}
		set
		{
			_dbExtra1 = value;
		}
	}
	
	public System.String DBExtra2
	{
		get
		{
			return _dbExtra2;
		}
		set
		{
			_dbExtra2 = value;
		}
	}
	
	public System.DateTime? DBDate
	{
		get
		{
			return _dbDate;
		}
		set
		{
			_dbDate = value;
		}
	}
	
	public System.Int32? DBStatus
	{
		get
		{
			return _dbStatus;
		}
		set
		{
			_dbStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("DB_BroucherID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Contactno", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_EmailID", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_SchoolName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_StaticID", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_PhysicalID", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_CountryName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_MiniBroucher", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("DB_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (DBBroucherID == null)
		dr["DB_BroucherID"] = DBNull.Value;
		else
		dr["DB_BroucherID"] = DBBroucherID;
		
		if (DBName == null)
		dr["DB_Name"] = DBNull.Value;
		else
		dr["DB_Name"] = DBName;
		
		if (DBContactno == null)
		dr["DB_Contactno"] = DBNull.Value;
		else
		dr["DB_Contactno"] = DBContactno;
		
		if (DBEmailID == null)
		dr["DB_EmailID"] = DBNull.Value;
		else
		dr["DB_EmailID"] = DBEmailID;
		
		if (DBDescription == null)
		dr["DB_Description"] = DBNull.Value;
		else
		dr["DB_Description"] = DBDescription;
		
		if (DBSchoolName == null)
		dr["DB_SchoolName"] = DBNull.Value;
		else
		dr["DB_SchoolName"] = DBSchoolName;
		
		if (DBStaticID == null)
		dr["DB_StaticID"] = DBNull.Value;
		else
		dr["DB_StaticID"] = DBStaticID;
		
		if (DBPhysicalID == null)
		dr["DB_PhysicalID"] = DBNull.Value;
		else
		dr["DB_PhysicalID"] = DBPhysicalID;
		
		if (DBCountryName == null)
		dr["DB_CountryName"] = DBNull.Value;
		else
		dr["DB_CountryName"] = DBCountryName;
		
		if (DBMiniBroucher == null)
		dr["DB_MiniBroucher"] = DBNull.Value;
		else
		dr["DB_MiniBroucher"] = DBMiniBroucher;
		
		if (DBExtra1 == null)
		dr["DB_Extra1"] = DBNull.Value;
		else
		dr["DB_Extra1"] = DBExtra1;
		
		if (DBExtra2 == null)
		dr["DB_Extra2"] = DBNull.Value;
		else
		dr["DB_Extra2"] = DBExtra2;
		
		if (DBDate == null)
		dr["DB_Date"] = DBNull.Value;
		else
		dr["DB_Date"] = DBDate;
		
		if (DBStatus == null)
		dr["DB_Status"] = DBNull.Value;
		else
		dr["DB_Status"] = DBStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		DBBroucherID = dr["DB_BroucherID"] != DBNull.Value ? Convert.ToInt64(dr["DB_BroucherID"]) : DBBroucherID = null;
		DBName = dr["DB_Name"] != DBNull.Value ? Convert.ToString(dr["DB_Name"]) : DBName = null;
		DBContactno = dr["DB_Contactno"] != DBNull.Value ? Convert.ToString(dr["DB_Contactno"]) : DBContactno = null;
		DBEmailID = dr["DB_EmailID"] != DBNull.Value ? Convert.ToString(dr["DB_EmailID"]) : DBEmailID = null;
		DBDescription = dr["DB_Description"] != DBNull.Value ? Convert.ToString(dr["DB_Description"]) : DBDescription = null;
		DBSchoolName = dr["DB_SchoolName"] != DBNull.Value ? Convert.ToString(dr["DB_SchoolName"]) : DBSchoolName = null;
		DBStaticID = dr["DB_StaticID"] != DBNull.Value ? Convert.ToString(dr["DB_StaticID"]) : DBStaticID = null;
		DBPhysicalID = dr["DB_PhysicalID"] != DBNull.Value ? Convert.ToString(dr["DB_PhysicalID"]) : DBPhysicalID = null;
		DBCountryName = dr["DB_CountryName"] != DBNull.Value ? Convert.ToString(dr["DB_CountryName"]) : DBCountryName = null;
		DBMiniBroucher = dr["DB_MiniBroucher"] != DBNull.Value ? Convert.ToString(dr["DB_MiniBroucher"]) : DBMiniBroucher = null;
		DBExtra1 = dr["DB_Extra1"] != DBNull.Value ? Convert.ToString(dr["DB_Extra1"]) : DBExtra1 = null;
		DBExtra2 = dr["DB_Extra2"] != DBNull.Value ? Convert.ToString(dr["DB_Extra2"]) : DBExtra2 = null;
		DBDate = dr["DB_Date"] != DBNull.Value ? Convert.ToDateTime(dr["DB_Date"]) : DBDate = null;
		DBStatus = dr["DB_Status"] != DBNull.Value ? Convert.ToInt32(dr["DB_Status"]) : DBStatus = null;
	}
	
	public static TMSDownloadBroucher[] MapFrom(DataSet ds)
	{
		List<TMSDownloadBroucher> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSDownloadBroucher>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_DownloadBroucher] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_DownloadBroucher] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSDownloadBroucher instance = new TMSDownloadBroucher();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSDownloadBroucher Get(System.Int64 dbBroucherID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSDownloadBroucher instance;
		
		
		instance = new TMSDownloadBroucher();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDownloadBroucher_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dbBroucherID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSDownloadBroucher ID:" + dbBroucherID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String dbName, System.String dbContactno, System.String dbEmailID, System.String dbDescription, System.String dbSchoolName, System.String dbStaticID, System.String dbPhysicalID, System.String dbCountryName, System.String dbMiniBroucher, System.String dbExtra1, System.String dbExtra2, System.DateTime? dbDate, System.Int32? dbStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDownloadBroucher_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dbName, dbContactno, dbEmailID, dbDescription, dbSchoolName, dbStaticID, dbPhysicalID, dbCountryName, dbMiniBroucher, dbExtra1, dbExtra2, dbDate, dbStatus);
		
		if (transaction == null)
		this.DBBroucherID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.DBBroucherID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String dbName, System.String dbContactno, System.String dbEmailID, System.String dbDescription, System.String dbSchoolName, System.String dbStaticID, System.String dbPhysicalID, System.String dbCountryName, System.String dbMiniBroucher, System.String dbExtra1, System.String dbExtra2, System.DateTime? dbDate, System.Int32? dbStatus)
	{
		Insert(dbName, dbContactno, dbEmailID, dbDescription, dbSchoolName, dbStaticID, dbPhysicalID, dbCountryName, dbMiniBroucher, dbExtra1, dbExtra2, dbDate, dbStatus, null);
	}
	/// <summary>
	/// Insert current TMSDownloadBroucher to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(DBName, DBContactno, DBEmailID, DBDescription, DBSchoolName, DBStaticID, DBPhysicalID, DBCountryName, DBMiniBroucher, DBExtra1, DBExtra2, DBDate, DBStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSDownloadBroucher to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? dbBroucherID, System.String dbName, System.String dbContactno, System.String dbEmailID, System.String dbDescription, System.String dbSchoolName, System.String dbStaticID, System.String dbPhysicalID, System.String dbCountryName, System.String dbMiniBroucher, System.String dbExtra1, System.String dbExtra2, System.DateTime? dbDate, System.Int32? dbStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDownloadBroucher_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dbBroucherID"].Value = dbBroucherID;
		dbCommand.Parameters["@dbName"].Value = dbName;
		dbCommand.Parameters["@dbContactno"].Value = dbContactno;
		dbCommand.Parameters["@dbEmailID"].Value = dbEmailID;
		dbCommand.Parameters["@dbDescription"].Value = dbDescription;
		dbCommand.Parameters["@dbSchoolName"].Value = dbSchoolName;
		dbCommand.Parameters["@dbStaticID"].Value = dbStaticID;
		dbCommand.Parameters["@dbPhysicalID"].Value = dbPhysicalID;
		dbCommand.Parameters["@dbCountryName"].Value = dbCountryName;
		dbCommand.Parameters["@dbMiniBroucher"].Value = dbMiniBroucher;
		dbCommand.Parameters["@dbExtra1"].Value = dbExtra1;
		dbCommand.Parameters["@dbExtra2"].Value = dbExtra2;
		dbCommand.Parameters["@dbDate"].Value = dbDate;
		dbCommand.Parameters["@dbStatus"].Value = dbStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? dbBroucherID, System.String dbName, System.String dbContactno, System.String dbEmailID, System.String dbDescription, System.String dbSchoolName, System.String dbStaticID, System.String dbPhysicalID, System.String dbCountryName, System.String dbMiniBroucher, System.String dbExtra1, System.String dbExtra2, System.DateTime? dbDate, System.Int32? dbStatus)
	{
		Update(dbBroucherID, dbName, dbContactno, dbEmailID, dbDescription, dbSchoolName, dbStaticID, dbPhysicalID, dbCountryName, dbMiniBroucher, dbExtra1, dbExtra2, dbDate, dbStatus, null);
	}
	
	public static void Update(TMSDownloadBroucher tMSDownloadBroucher)
	{
		tMSDownloadBroucher.Update();
	}
	
	public static void Update(TMSDownloadBroucher tMSDownloadBroucher, DbTransaction transaction)
	{
		tMSDownloadBroucher.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSDownloadBroucher_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dbBroucherID"].SourceColumn = "DB_BroucherID";
		dbCommand.Parameters["@dbName"].SourceColumn = "DB_Name";
		dbCommand.Parameters["@dbContactno"].SourceColumn = "DB_Contactno";
		dbCommand.Parameters["@dbEmailID"].SourceColumn = "DB_EmailID";
		dbCommand.Parameters["@dbDescription"].SourceColumn = "DB_Description";
		dbCommand.Parameters["@dbSchoolName"].SourceColumn = "DB_SchoolName";
		dbCommand.Parameters["@dbStaticID"].SourceColumn = "DB_StaticID";
		dbCommand.Parameters["@dbPhysicalID"].SourceColumn = "DB_PhysicalID";
		dbCommand.Parameters["@dbCountryName"].SourceColumn = "DB_CountryName";
		dbCommand.Parameters["@dbMiniBroucher"].SourceColumn = "DB_MiniBroucher";
		dbCommand.Parameters["@dbExtra1"].SourceColumn = "DB_Extra1";
		dbCommand.Parameters["@dbExtra2"].SourceColumn = "DB_Extra2";
		dbCommand.Parameters["@dbDate"].SourceColumn = "DB_Date";
		dbCommand.Parameters["@dbStatus"].SourceColumn = "DB_Status";
		
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
	public static void Delete(System.Int64? dbBroucherID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDownloadBroucher_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dbBroucherID);
		
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
	public static void Delete(System.Int64? dbBroucherID)
	{
		Delete(
		dbBroucherID);
	}
	
	/// <summary>
	/// Delete current TMSDownloadBroucher from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDownloadBroucher_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, DBBroucherID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.DBBroucherID = null;
	}
	
	/// <summary>
	/// Delete current TMSDownloadBroucher from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSDownloadBroucher[] Search(System.Int64? dbBroucherID, System.String dbName, System.String dbContactno, System.String dbEmailID, System.String dbDescription, System.String dbSchoolName, System.String dbStaticID, System.String dbPhysicalID, System.String dbCountryName, System.String dbMiniBroucher, System.String dbExtra1, System.String dbExtra2, System.DateTime? dbDate, System.Int32? dbStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDownloadBroucher_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dbBroucherID, dbName, dbContactno, dbEmailID, dbDescription, dbSchoolName, dbStaticID, dbPhysicalID, dbCountryName, dbMiniBroucher, dbExtra1, dbExtra2, dbDate, dbStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSDownloadBroucher.MapFrom(ds);
	}
	
	
	public static TMSDownloadBroucher[] Search(TMSDownloadBroucher searchObject)
	{
		return Search ( searchObject.DBBroucherID, searchObject.DBName, searchObject.DBContactno, searchObject.DBEmailID, searchObject.DBDescription, searchObject.DBSchoolName, searchObject.DBStaticID, searchObject.DBPhysicalID, searchObject.DBCountryName, searchObject.DBMiniBroucher, searchObject.DBExtra1, searchObject.DBExtra2, searchObject.DBDate, searchObject.DBStatus);
	}
	
	/// <summary>
	/// Returns all TMSDownloadBroucher objects.
	/// </summary>
	/// <returns>List of all TMSDownloadBroucher objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSDownloadBroucher[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

