/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/31/2012 4:51:33 PM                                    */
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
public partial class TMSCoScholasticSkillType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_CoScholasticSkillType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _stSkillId;
	private System.Int64? _stSchoolId;
	private System.String _stSkillName;
	private System.String _stSkillDescription;
	private System.String _stExtra;
	private System.DateTime? _stDate;
	private System.Int32? _stStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? STSkillId
	{
		get
		{
			return _stSkillId;
		}
		set
		{
			_stSkillId = value;
		}
	}
	
	public System.Int64? STSchoolId
	{
		get
		{
			return _stSchoolId;
		}
		set
		{
			_stSchoolId = value;
		}
	}
	
	public System.String STSkillName
	{
		get
		{
			return _stSkillName;
		}
		set
		{
			_stSkillName = value;
		}
	}
	
	public System.String STSkillDescription
	{
		get
		{
			return _stSkillDescription;
		}
		set
		{
			_stSkillDescription = value;
		}
	}
	
	public System.String STExtra
	{
		get
		{
			return _stExtra;
		}
		set
		{
			_stExtra = value;
		}
	}
	
	public System.DateTime? STDate
	{
		get
		{
			return _stDate;
		}
		set
		{
			_stDate = value;
		}
	}
	
	public System.Int32? STStatus
	{
		get
		{
			return _stStatus;
		}
		set
		{
			_stStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ST_SkillId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_SkillName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_SkillDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (STSkillId == null)
		dr["ST_SkillId"] = DBNull.Value;
		else
		dr["ST_SkillId"] = STSkillId;
		
		if (STSchoolId == null)
		dr["ST_SchoolId"] = DBNull.Value;
		else
		dr["ST_SchoolId"] = STSchoolId;
		
		if (STSkillName == null)
		dr["ST_SkillName"] = DBNull.Value;
		else
		dr["ST_SkillName"] = STSkillName;
		
		if (STSkillDescription == null)
		dr["ST_SkillDescription"] = DBNull.Value;
		else
		dr["ST_SkillDescription"] = STSkillDescription;
		
		if (STExtra == null)
		dr["ST_Extra"] = DBNull.Value;
		else
		dr["ST_Extra"] = STExtra;
		
		if (STDate == null)
		dr["ST_Date"] = DBNull.Value;
		else
		dr["ST_Date"] = STDate;
		
		if (STStatus == null)
		dr["ST_Status"] = DBNull.Value;
		else
		dr["ST_Status"] = STStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		STSkillId = dr["ST_SkillId"] != DBNull.Value ? Convert.ToInt64(dr["ST_SkillId"]) : STSkillId = null;
		STSchoolId = dr["ST_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ST_SchoolId"]) : STSchoolId = null;
		STSkillName = dr["ST_SkillName"] != DBNull.Value ? Convert.ToString(dr["ST_SkillName"]) : STSkillName = null;
		STSkillDescription = dr["ST_SkillDescription"] != DBNull.Value ? Convert.ToString(dr["ST_SkillDescription"]) : STSkillDescription = null;
		STExtra = dr["ST_Extra"] != DBNull.Value ? Convert.ToString(dr["ST_Extra"]) : STExtra = null;
		STDate = dr["ST_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ST_Date"]) : STDate = null;
		STStatus = dr["ST_Status"] != DBNull.Value ? Convert.ToInt32(dr["ST_Status"]) : STStatus = null;
	}
	
	public static TMSCoScholasticSkillType[] MapFrom(DataSet ds)
	{
		List<TMSCoScholasticSkillType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCoScholasticSkillType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_CoScholasticSkillType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_CoScholasticSkillType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCoScholasticSkillType instance = new TMSCoScholasticSkillType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticSkillType Get(System.Int64 stSkillId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCoScholasticSkillType instance;
		
		
		instance = new TMSCoScholasticSkillType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSCoScholasticSkillType ID:" + stSkillId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? stSchoolId, System.String stSkillName, System.String stSkillDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSchoolId, stSkillName, stSkillDescription, stExtra, stDate, stStatus);
		
		if (transaction == null)
		this.STSkillId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.STSkillId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? stSchoolId, System.String stSkillName, System.String stSkillDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
	{
		Insert(stSchoolId, stSkillName, stSkillDescription, stExtra, stDate, stStatus, null);
	}
	/// <summary>
	/// Insert current TMSCoScholasticSkillType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(STSchoolId, STSkillName, STSkillDescription, STExtra, STDate, STStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCoScholasticSkillType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? stSkillId, System.Int64? stSchoolId, System.String stSkillName, System.String stSkillDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stSkillId"].Value = stSkillId;
		dbCommand.Parameters["@stSchoolId"].Value = stSchoolId;
		dbCommand.Parameters["@stSkillName"].Value = stSkillName;
		dbCommand.Parameters["@stSkillDescription"].Value = stSkillDescription;
		dbCommand.Parameters["@stExtra"].Value = stExtra;
		dbCommand.Parameters["@stDate"].Value = stDate;
		dbCommand.Parameters["@stStatus"].Value = stStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? stSkillId, System.Int64? stSchoolId, System.String stSkillName, System.String stSkillDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
	{
		Update(stSkillId, stSchoolId, stSkillName, stSkillDescription, stExtra, stDate, stStatus, null);
	}
	
	public static void Update(TMSCoScholasticSkillType tMSCoScholasticSkillType)
	{
		tMSCoScholasticSkillType.Update();
	}
	
	public static void Update(TMSCoScholasticSkillType tMSCoScholasticSkillType, DbTransaction transaction)
	{
		tMSCoScholasticSkillType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stSkillId"].SourceColumn = "ST_SkillId";
		dbCommand.Parameters["@stSchoolId"].SourceColumn = "ST_SchoolId";
		dbCommand.Parameters["@stSkillName"].SourceColumn = "ST_SkillName";
		dbCommand.Parameters["@stSkillDescription"].SourceColumn = "ST_SkillDescription";
		dbCommand.Parameters["@stExtra"].SourceColumn = "ST_Extra";
		dbCommand.Parameters["@stDate"].SourceColumn = "ST_Date";
		dbCommand.Parameters["@stStatus"].SourceColumn = "ST_Status";
		
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
	public static void Delete(System.Int64? stSkillId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillId);
		
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
	public static void Delete(System.Int64? stSkillId)
	{
		Delete(
		stSkillId);
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticSkillType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, STSkillId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.STSkillId = null;
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticSkillType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticSkillType[] Search(System.Int64? stSkillId, System.Int64? stSchoolId, System.String stSkillName, System.String stSkillDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillId, stSchoolId, stSkillName, stSkillDescription, stExtra, stDate, stStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCoScholasticSkillType.MapFrom(ds);
	}
	
	
	public static TMSCoScholasticSkillType[] Search(TMSCoScholasticSkillType searchObject)
	{
		return Search ( searchObject.STSkillId, searchObject.STSchoolId, searchObject.STSkillName, searchObject.STSkillDescription, searchObject.STExtra, searchObject.STDate, searchObject.STStatus);
	}
	
	/// <summary>
	/// Returns all TMSCoScholasticSkillType objects.
	/// </summary>
	/// <returns>List of all TMSCoScholasticSkillType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCoScholasticSkillType[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

