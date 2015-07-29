/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 5:07:23 PM                                    */
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
public partial class TMSQualification
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Qualification]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _qualId;
	private System.String _qualQualification;
	private System.Int32? _qualStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? QUALId
	{
		get
		{
			return _qualId;
		}
		set
		{
			_qualId = value;
		}
	}
	
	public System.String QUALQualification
	{
		get
		{
			return _qualQualification;
		}
		set
		{
			_qualQualification = value;
		}
	}
	
	public System.Int32? QUALStatus
	{
		get
		{
			return _qualStatus;
		}
		set
		{
			_qualStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("QUAL_id", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("QUAL_Qualification", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QUAL_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (QUALId == null)
		dr["QUAL_id"] = DBNull.Value;
		else
		dr["QUAL_id"] = QUALId;
		
		if (QUALQualification == null)
		dr["QUAL_Qualification"] = DBNull.Value;
		else
		dr["QUAL_Qualification"] = QUALQualification;
		
		if (QUALStatus == null)
		dr["QUAL_Status"] = DBNull.Value;
		else
		dr["QUAL_Status"] = QUALStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		QUALId = dr["QUAL_id"] != DBNull.Value ? Convert.ToInt64(dr["QUAL_id"]) : QUALId = null;
		QUALQualification = dr["QUAL_Qualification"] != DBNull.Value ? Convert.ToString(dr["QUAL_Qualification"]) : QUALQualification = null;
		QUALStatus = dr["QUAL_Status"] != DBNull.Value ? Convert.ToInt32(dr["QUAL_Status"]) : QUALStatus = null;
	}
	
	public static TMSQualification[] MapFrom(DataSet ds)
	{
		List<TMSQualification> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSQualification>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Qualification] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Qualification] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSQualification instance = new TMSQualification();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSQualification Get(System.Int64 qualId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSQualification instance;
		
		
		instance = new TMSQualification();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQualification_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qualId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSQualification ID:" + qualId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String qualQualification, System.Int32? qualStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQualification_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qualQualification, qualStatus);
		
		if (transaction == null)
		this.QUALId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.QUALId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String qualQualification, System.Int32? qualStatus)
	{
		Insert(qualQualification, qualStatus, null);
	}
	/// <summary>
	/// Insert current TMSQualification to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(QUALQualification, QUALStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSQualification to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? qualId, System.String qualQualification, System.Int32? qualStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQualification_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@qualId"].Value = qualId;
		dbCommand.Parameters["@qualQualification"].Value = qualQualification;
		dbCommand.Parameters["@qualStatus"].Value = qualStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? qualId, System.String qualQualification, System.Int32? qualStatus)
	{
		Update(qualId, qualQualification, qualStatus, null);
	}
	
	public static void Update(TMSQualification tMSQualification)
	{
		tMSQualification.Update();
	}
	
	public static void Update(TMSQualification tMSQualification, DbTransaction transaction)
	{
		tMSQualification.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSQualification_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@qualId"].SourceColumn = "QUAL_id";
		dbCommand.Parameters["@qualQualification"].SourceColumn = "QUAL_Qualification";
		dbCommand.Parameters["@qualStatus"].SourceColumn = "QUAL_Status";
		
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
	public static void Delete(System.Int64? qualId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQualification_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qualId);
		
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
	public static void Delete(System.Int64? qualId)
	{
		Delete(
		qualId);
	}
	
	/// <summary>
	/// Delete current TMSQualification from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQualification_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, QUALId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.QUALId = null;
	}
	
	/// <summary>
	/// Delete current TMSQualification from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSQualification[] Search(System.Int64? qualId, System.String qualQualification, System.Int32? qualStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQualification_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qualId, qualQualification, qualStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSQualification.MapFrom(ds);
	}
	
	
	public static TMSQualification[] Search(TMSQualification searchObject)
	{
		return Search ( searchObject.QUALId, searchObject.QUALQualification, searchObject.QUALStatus);
	}
	
	/// <summary>
	/// Returns all TMSQualification objects.
	/// </summary>
	/// <returns>List of all TMSQualification objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSQualification[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

