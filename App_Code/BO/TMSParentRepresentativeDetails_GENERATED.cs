/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/2/2012 2:52:57 PM                                    */
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
public partial class TMSParentRepresentativeDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ParentRepresentativeDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _prpDetailsID;
	private System.Int64? _prpParentRepresentativeID;
	private System.Int64? _prpParentLoginID;
	private System.Int64? _prpStudentLoginID;
	private System.Int64? _prpStandardID;
	private System.Int64? _prpDivisionID;
	private System.String _prpSubject;
	private System.String _prpDescription;
	private System.String _prpDescription1;
	private System.DateTime? _prpDate;
	private System.Int32? _prpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PRPDetailsID
	{
		get
		{
			return _prpDetailsID;
		}
		set
		{
			_prpDetailsID = value;
		}
	}
	
	public System.Int64? PRPParentRepresentativeID
	{
		get
		{
			return _prpParentRepresentativeID;
		}
		set
		{
			_prpParentRepresentativeID = value;
		}
	}
	
	public System.Int64? PRPParentLoginID
	{
		get
		{
			return _prpParentLoginID;
		}
		set
		{
			_prpParentLoginID = value;
		}
	}
	
	public System.Int64? PRPStudentLoginID
	{
		get
		{
			return _prpStudentLoginID;
		}
		set
		{
			_prpStudentLoginID = value;
		}
	}
	
	public System.Int64? PRPStandardID
	{
		get
		{
			return _prpStandardID;
		}
		set
		{
			_prpStandardID = value;
		}
	}
	
	public System.Int64? PrpDivisionID
	{
		get
		{
			return _prpDivisionID;
		}
		set
		{
			_prpDivisionID = value;
		}
	}
	
	public System.String PrpSubject
	{
		get
		{
			return _prpSubject;
		}
		set
		{
			_prpSubject = value;
		}
	}
	
	public System.String PrpDescription
	{
		get
		{
			return _prpDescription;
		}
		set
		{
			_prpDescription = value;
		}
	}
	
	public System.String PrpDescription1
	{
		get
		{
			return _prpDescription1;
		}
		set
		{
			_prpDescription1 = value;
		}
	}
	
	public System.DateTime? PrpDate
	{
		get
		{
			return _prpDate;
		}
		set
		{
			_prpDate = value;
		}
	}
	
	public System.Int32? PrpStatus
	{
		get
		{
			return _prpStatus;
		}
		set
		{
			_prpStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PRP_DetailsID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PRP_ParentRepresentativeID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PRP_ParentLoginID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PRP_StudentLoginID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PRP_StandardID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("prp_DivisionID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("prp_Subject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("prp_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("prp_Description1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("prp_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("prp_status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PRPDetailsID == null)
		dr["PRP_DetailsID"] = DBNull.Value;
		else
		dr["PRP_DetailsID"] = PRPDetailsID;
		
		if (PRPParentRepresentativeID == null)
		dr["PRP_ParentRepresentativeID"] = DBNull.Value;
		else
		dr["PRP_ParentRepresentativeID"] = PRPParentRepresentativeID;
		
		if (PRPParentLoginID == null)
		dr["PRP_ParentLoginID"] = DBNull.Value;
		else
		dr["PRP_ParentLoginID"] = PRPParentLoginID;
		
		if (PRPStudentLoginID == null)
		dr["PRP_StudentLoginID"] = DBNull.Value;
		else
		dr["PRP_StudentLoginID"] = PRPStudentLoginID;
		
		if (PRPStandardID == null)
		dr["PRP_StandardID"] = DBNull.Value;
		else
		dr["PRP_StandardID"] = PRPStandardID;
		
		if (PrpDivisionID == null)
		dr["prp_DivisionID"] = DBNull.Value;
		else
		dr["prp_DivisionID"] = PrpDivisionID;
		
		if (PrpSubject == null)
		dr["prp_Subject"] = DBNull.Value;
		else
		dr["prp_Subject"] = PrpSubject;
		
		if (PrpDescription == null)
		dr["prp_Description"] = DBNull.Value;
		else
		dr["prp_Description"] = PrpDescription;
		
		if (PrpDescription1 == null)
		dr["prp_Description1"] = DBNull.Value;
		else
		dr["prp_Description1"] = PrpDescription1;
		
		if (PrpDate == null)
		dr["prp_Date"] = DBNull.Value;
		else
		dr["prp_Date"] = PrpDate;
		
		if (PrpStatus == null)
		dr["prp_status"] = DBNull.Value;
		else
		dr["prp_status"] = PrpStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PRPDetailsID = dr["PRP_DetailsID"] != DBNull.Value ? Convert.ToInt64(dr["PRP_DetailsID"]) : PRPDetailsID = null;
		PRPParentRepresentativeID = dr["PRP_ParentRepresentativeID"] != DBNull.Value ? Convert.ToInt64(dr["PRP_ParentRepresentativeID"]) : PRPParentRepresentativeID = null;
		PRPParentLoginID = dr["PRP_ParentLoginID"] != DBNull.Value ? Convert.ToInt64(dr["PRP_ParentLoginID"]) : PRPParentLoginID = null;
		PRPStudentLoginID = dr["PRP_StudentLoginID"] != DBNull.Value ? Convert.ToInt64(dr["PRP_StudentLoginID"]) : PRPStudentLoginID = null;
		PRPStandardID = dr["PRP_StandardID"] != DBNull.Value ? Convert.ToInt64(dr["PRP_StandardID"]) : PRPStandardID = null;
		PrpDivisionID = dr["prp_DivisionID"] != DBNull.Value ? Convert.ToInt64(dr["prp_DivisionID"]) : PrpDivisionID = null;
		PrpSubject = dr["prp_Subject"] != DBNull.Value ? Convert.ToString(dr["prp_Subject"]) : PrpSubject = null;
		PrpDescription = dr["prp_Description"] != DBNull.Value ? Convert.ToString(dr["prp_Description"]) : PrpDescription = null;
		PrpDescription1 = dr["prp_Description1"] != DBNull.Value ? Convert.ToString(dr["prp_Description1"]) : PrpDescription1 = null;
		PrpDate = dr["prp_Date"] != DBNull.Value ? Convert.ToDateTime(dr["prp_Date"]) : PrpDate = null;
		PrpStatus = dr["prp_status"] != DBNull.Value ? Convert.ToInt32(dr["prp_status"]) : PrpStatus = null;
	}
	
	public static TMSParentRepresentativeDetails[] MapFrom(DataSet ds)
	{
		List<TMSParentRepresentativeDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSParentRepresentativeDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ParentRepresentativeDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ParentRepresentativeDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSParentRepresentativeDetails instance = new TMSParentRepresentativeDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentRepresentativeDetails Get(System.Int64 prpDetailsID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSParentRepresentativeDetails instance;
		
		
		instance = new TMSParentRepresentativeDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prpDetailsID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSParentRepresentativeDetails ID:" + prpDetailsID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? prpParentRepresentativeID, System.Int64? prpParentLoginID, System.Int64? prpStudentLoginID, System.Int64? prpStandardID, System.Int64? prpDivisionID, System.String prpSubject, System.String prpDescription, System.String prpDescription1, System.DateTime? prpDate, System.Int32? prpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prpParentRepresentativeID, prpParentLoginID, prpStudentLoginID, prpStandardID, prpDivisionID, prpSubject, prpDescription, prpDescription1, prpDate, prpStatus);
		
		if (transaction == null)
		this.PRPDetailsID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PRPDetailsID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? prpParentRepresentativeID, System.Int64? prpParentLoginID, System.Int64? prpStudentLoginID, System.Int64? prpStandardID, System.Int64? prpDivisionID, System.String prpSubject, System.String prpDescription, System.String prpDescription1, System.DateTime? prpDate, System.Int32? prpStatus)
	{
		Insert(prpParentRepresentativeID, prpParentLoginID, prpStudentLoginID, prpStandardID, prpDivisionID, prpSubject, prpDescription, prpDescription1, prpDate, prpStatus, null);
	}
	/// <summary>
	/// Insert current TMSParentRepresentativeDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PRPParentRepresentativeID, PRPParentLoginID, PRPStudentLoginID, PRPStandardID, PrpDivisionID, PrpSubject, PrpDescription, PrpDescription1, PrpDate, PrpStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSParentRepresentativeDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? prpDetailsID, System.Int64? prpParentRepresentativeID, System.Int64? prpParentLoginID, System.Int64? prpStudentLoginID, System.Int64? prpStandardID, System.Int64? prpDivisionID, System.String prpSubject, System.String prpDescription, System.String prpDescription1, System.DateTime? prpDate, System.Int32? prpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@prpDetailsID"].Value = prpDetailsID;
		dbCommand.Parameters["@prpParentRepresentativeID"].Value = prpParentRepresentativeID;
		dbCommand.Parameters["@prpParentLoginID"].Value = prpParentLoginID;
		dbCommand.Parameters["@prpStudentLoginID"].Value = prpStudentLoginID;
		dbCommand.Parameters["@prpStandardID"].Value = prpStandardID;
		dbCommand.Parameters["@prpDivisionID"].Value = prpDivisionID;
		dbCommand.Parameters["@prpSubject"].Value = prpSubject;
		dbCommand.Parameters["@prpDescription"].Value = prpDescription;
		dbCommand.Parameters["@prpDescription1"].Value = prpDescription1;
		dbCommand.Parameters["@prpDate"].Value = prpDate;
		dbCommand.Parameters["@prpStatus"].Value = prpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? prpDetailsID, System.Int64? prpParentRepresentativeID, System.Int64? prpParentLoginID, System.Int64? prpStudentLoginID, System.Int64? prpStandardID, System.Int64? prpDivisionID, System.String prpSubject, System.String prpDescription, System.String prpDescription1, System.DateTime? prpDate, System.Int32? prpStatus)
	{
		Update(prpDetailsID, prpParentRepresentativeID, prpParentLoginID, prpStudentLoginID, prpStandardID, prpDivisionID, prpSubject, prpDescription, prpDescription1, prpDate, prpStatus, null);
	}
	
	public static void Update(TMSParentRepresentativeDetails tMSParentRepresentativeDetails)
	{
		tMSParentRepresentativeDetails.Update();
	}
	
	public static void Update(TMSParentRepresentativeDetails tMSParentRepresentativeDetails, DbTransaction transaction)
	{
		tMSParentRepresentativeDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@prpDetailsID"].SourceColumn = "PRP_DetailsID";
		dbCommand.Parameters["@prpParentRepresentativeID"].SourceColumn = "PRP_ParentRepresentativeID";
		dbCommand.Parameters["@prpParentLoginID"].SourceColumn = "PRP_ParentLoginID";
		dbCommand.Parameters["@prpStudentLoginID"].SourceColumn = "PRP_StudentLoginID";
		dbCommand.Parameters["@prpStandardID"].SourceColumn = "PRP_StandardID";
		dbCommand.Parameters["@prpDivisionID"].SourceColumn = "prp_DivisionID";
		dbCommand.Parameters["@prpSubject"].SourceColumn = "prp_Subject";
		dbCommand.Parameters["@prpDescription"].SourceColumn = "prp_Description";
		dbCommand.Parameters["@prpDescription1"].SourceColumn = "prp_Description1";
		dbCommand.Parameters["@prpDate"].SourceColumn = "prp_Date";
		dbCommand.Parameters["@prpStatus"].SourceColumn = "prp_status";
		
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
	public static void Delete(System.Int64? prpDetailsID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prpDetailsID);
		
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
	public static void Delete(System.Int64? prpDetailsID)
	{
		Delete(
		prpDetailsID);
	}
	
	/// <summary>
	/// Delete current TMSParentRepresentativeDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PRPDetailsID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PRPDetailsID = null;
	}
	
	/// <summary>
	/// Delete current TMSParentRepresentativeDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentRepresentativeDetails[] Search(System.Int64? prpDetailsID, System.Int64? prpParentRepresentativeID, System.Int64? prpParentLoginID, System.Int64? prpStudentLoginID, System.Int64? prpStandardID, System.Int64? prpDivisionID, System.String prpSubject, System.String prpDescription, System.String prpDescription1, System.DateTime? prpDate, System.Int32? prpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentativeDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prpDetailsID, prpParentRepresentativeID, prpParentLoginID, prpStudentLoginID, prpStandardID, prpDivisionID, prpSubject, prpDescription, prpDescription1, prpDate, prpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSParentRepresentativeDetails.MapFrom(ds);
	}
	
	
	public static TMSParentRepresentativeDetails[] Search(TMSParentRepresentativeDetails searchObject)
	{
		return Search ( searchObject.PRPDetailsID, searchObject.PRPParentRepresentativeID, searchObject.PRPParentLoginID, searchObject.PRPStudentLoginID, searchObject.PRPStandardID, searchObject.PrpDivisionID, searchObject.PrpSubject, searchObject.PrpDescription, searchObject.PrpDescription1, searchObject.PrpDate, searchObject.PrpStatus);
	}
	
	/// <summary>
	/// Returns all TMSParentRepresentativeDetails objects.
	/// </summary>
	/// <returns>List of all TMSParentRepresentativeDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSParentRepresentativeDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

