/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/29/2013 5:39:11 PM                                    */
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
public partial class TMSBookIssuedDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BookIssuedDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bidBookId;
	private System.Int64? _bidLibraryManagerId;
	private System.Int64? _bidUserLoginId;
	private System.Int64? _bidSubjectId;
	private System.Int64? _bidStandardId;
	private System.Int64? _bidDivisionId;
	private System.Int64? _bidBookDetailsId;
	private System.DateTime? _bidBookIssuedDate;
	private System.DateTime? _bidBookSubmitDate;
	private System.Double? _bidBookLateFees;
	private System.Double? _bidBookDeposite;
	private System.Double? _bidBookOhterCharges;
	private System.String _bidBookSubmittedStatus;
	private System.String _bidBookExtraColumn1;
	private System.String _bidBookExtraColumn2;
	private System.String _bidBookExtraColumn3;
	private System.String _bidBookExtraColumn4;
	private System.Double? _bidBookExtraFees1;
	private System.Double? _bidBookExtraFees2;
	private System.DateTime? _bidBookExtraDate1;
	private System.DateTime? _bidBookExtraDate2;
	private System.Boolean? _bidStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BIDBookId
	{
		get
		{
			return _bidBookId;
		}
		set
		{
			_bidBookId = value;
		}
	}
	
	public System.Int64? BIDLibraryManagerId
	{
		get
		{
			return _bidLibraryManagerId;
		}
		set
		{
			_bidLibraryManagerId = value;
		}
	}
	
	public System.Int64? BIDUserLoginId
	{
		get
		{
			return _bidUserLoginId;
		}
		set
		{
			_bidUserLoginId = value;
		}
	}
	
	public System.Int64? BIDSubjectId
	{
		get
		{
			return _bidSubjectId;
		}
		set
		{
			_bidSubjectId = value;
		}
	}
	
	public System.Int64? BIDStandardId
	{
		get
		{
			return _bidStandardId;
		}
		set
		{
			_bidStandardId = value;
		}
	}
	
	public System.Int64? BIDDivisionId
	{
		get
		{
			return _bidDivisionId;
		}
		set
		{
			_bidDivisionId = value;
		}
	}
	
	public System.Int64? BIDBookDetailsId
	{
		get
		{
			return _bidBookDetailsId;
		}
		set
		{
			_bidBookDetailsId = value;
		}
	}
	
	public System.DateTime? BIDBookIssuedDate
	{
		get
		{
			return _bidBookIssuedDate;
		}
		set
		{
			_bidBookIssuedDate = value;
		}
	}
	
	public System.DateTime? BIDBookSubmitDate
	{
		get
		{
			return _bidBookSubmitDate;
		}
		set
		{
			_bidBookSubmitDate = value;
		}
	}
	
	public System.Double? BIDBookLateFees
	{
		get
		{
			return _bidBookLateFees;
		}
		set
		{
			_bidBookLateFees = value;
		}
	}
	
	public System.Double? BIDBookDeposite
	{
		get
		{
			return _bidBookDeposite;
		}
		set
		{
			_bidBookDeposite = value;
		}
	}
	
	public System.Double? BIDBookOhterCharges
	{
		get
		{
			return _bidBookOhterCharges;
		}
		set
		{
			_bidBookOhterCharges = value;
		}
	}
	
	public System.String BIDBookSubmittedStatus
	{
		get
		{
			return _bidBookSubmittedStatus;
		}
		set
		{
			_bidBookSubmittedStatus = value;
		}
	}
	
	public System.String BIDBookExtraColumn1
	{
		get
		{
			return _bidBookExtraColumn1;
		}
		set
		{
			_bidBookExtraColumn1 = value;
		}
	}
	
	public System.String BIDBookExtraColumn2
	{
		get
		{
			return _bidBookExtraColumn2;
		}
		set
		{
			_bidBookExtraColumn2 = value;
		}
	}
	
	public System.String BIDBookExtraColumn3
	{
		get
		{
			return _bidBookExtraColumn3;
		}
		set
		{
			_bidBookExtraColumn3 = value;
		}
	}
	
	public System.String BIDBookExtraColumn4
	{
		get
		{
			return _bidBookExtraColumn4;
		}
		set
		{
			_bidBookExtraColumn4 = value;
		}
	}
	
	public System.Double? BIDBookExtraFees1
	{
		get
		{
			return _bidBookExtraFees1;
		}
		set
		{
			_bidBookExtraFees1 = value;
		}
	}
	
	public System.Double? BIDBookExtraFees2
	{
		get
		{
			return _bidBookExtraFees2;
		}
		set
		{
			_bidBookExtraFees2 = value;
		}
	}
	
	public System.DateTime? BIDBookExtraDate1
	{
		get
		{
			return _bidBookExtraDate1;
		}
		set
		{
			_bidBookExtraDate1 = value;
		}
	}
	
	public System.DateTime? BIDBookExtraDate2
	{
		get
		{
			return _bidBookExtraDate2;
		}
		set
		{
			_bidBookExtraDate2 = value;
		}
	}
	
	public System.Boolean? BIDStatus
	{
		get
		{
			return _bidStatus;
		}
		set
		{
			_bidStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_LibraryManagerId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_UserLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_StandardId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_DivisionId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookIssuedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookSubmitDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookLateFees", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookDeposite", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookOhterCharges", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookSubmittedStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraColumn1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraColumn2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraColumn3", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraColumn4", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraFees1", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraFees2", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraDate1", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_BookExtraDate2", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BID_Status", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BIDBookId == null)
		dr["BID_BookId"] = DBNull.Value;
		else
		dr["BID_BookId"] = BIDBookId;
		
		if (BIDLibraryManagerId == null)
		dr["BID_LibraryManagerId"] = DBNull.Value;
		else
		dr["BID_LibraryManagerId"] = BIDLibraryManagerId;
		
		if (BIDUserLoginId == null)
		dr["BID_UserLoginId"] = DBNull.Value;
		else
		dr["BID_UserLoginId"] = BIDUserLoginId;
		
		if (BIDSubjectId == null)
		dr["BID_SubjectId"] = DBNull.Value;
		else
		dr["BID_SubjectId"] = BIDSubjectId;
		
		if (BIDStandardId == null)
		dr["BID_StandardId"] = DBNull.Value;
		else
		dr["BID_StandardId"] = BIDStandardId;
		
		if (BIDDivisionId == null)
		dr["BID_DivisionId"] = DBNull.Value;
		else
		dr["BID_DivisionId"] = BIDDivisionId;
		
		if (BIDBookDetailsId == null)
		dr["BID_BookDetailsId"] = DBNull.Value;
		else
		dr["BID_BookDetailsId"] = BIDBookDetailsId;
		
		if (BIDBookIssuedDate == null)
		dr["BID_BookIssuedDate"] = DBNull.Value;
		else
		dr["BID_BookIssuedDate"] = BIDBookIssuedDate;
		
		if (BIDBookSubmitDate == null)
		dr["BID_BookSubmitDate"] = DBNull.Value;
		else
		dr["BID_BookSubmitDate"] = BIDBookSubmitDate;
		
		if (BIDBookLateFees == null)
		dr["BID_BookLateFees"] = DBNull.Value;
		else
		dr["BID_BookLateFees"] = BIDBookLateFees;
		
		if (BIDBookDeposite == null)
		dr["BID_BookDeposite"] = DBNull.Value;
		else
		dr["BID_BookDeposite"] = BIDBookDeposite;
		
		if (BIDBookOhterCharges == null)
		dr["BID_BookOhterCharges"] = DBNull.Value;
		else
		dr["BID_BookOhterCharges"] = BIDBookOhterCharges;
		
		if (BIDBookSubmittedStatus == null)
		dr["BID_BookSubmittedStatus"] = DBNull.Value;
		else
		dr["BID_BookSubmittedStatus"] = BIDBookSubmittedStatus;
		
		if (BIDBookExtraColumn1 == null)
		dr["BID_BookExtraColumn1"] = DBNull.Value;
		else
		dr["BID_BookExtraColumn1"] = BIDBookExtraColumn1;
		
		if (BIDBookExtraColumn2 == null)
		dr["BID_BookExtraColumn2"] = DBNull.Value;
		else
		dr["BID_BookExtraColumn2"] = BIDBookExtraColumn2;
		
		if (BIDBookExtraColumn3 == null)
		dr["BID_BookExtraColumn3"] = DBNull.Value;
		else
		dr["BID_BookExtraColumn3"] = BIDBookExtraColumn3;
		
		if (BIDBookExtraColumn4 == null)
		dr["BID_BookExtraColumn4"] = DBNull.Value;
		else
		dr["BID_BookExtraColumn4"] = BIDBookExtraColumn4;
		
		if (BIDBookExtraFees1 == null)
		dr["BID_BookExtraFees1"] = DBNull.Value;
		else
		dr["BID_BookExtraFees1"] = BIDBookExtraFees1;
		
		if (BIDBookExtraFees2 == null)
		dr["BID_BookExtraFees2"] = DBNull.Value;
		else
		dr["BID_BookExtraFees2"] = BIDBookExtraFees2;
		
		if (BIDBookExtraDate1 == null)
		dr["BID_BookExtraDate1"] = DBNull.Value;
		else
		dr["BID_BookExtraDate1"] = BIDBookExtraDate1;
		
		if (BIDBookExtraDate2 == null)
		dr["BID_BookExtraDate2"] = DBNull.Value;
		else
		dr["BID_BookExtraDate2"] = BIDBookExtraDate2;
		
		if (BIDStatus == null)
		dr["BID_Status"] = DBNull.Value;
		else
		dr["BID_Status"] = BIDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BIDBookId = dr["BID_BookId"] != DBNull.Value ? Convert.ToInt64(dr["BID_BookId"]) : BIDBookId = null;
		BIDLibraryManagerId = dr["BID_LibraryManagerId"] != DBNull.Value ? Convert.ToInt64(dr["BID_LibraryManagerId"]) : BIDLibraryManagerId = null;
		BIDUserLoginId = dr["BID_UserLoginId"] != DBNull.Value ? Convert.ToInt64(dr["BID_UserLoginId"]) : BIDUserLoginId = null;
		BIDSubjectId = dr["BID_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["BID_SubjectId"]) : BIDSubjectId = null;
		BIDStandardId = dr["BID_StandardId"] != DBNull.Value ? Convert.ToInt64(dr["BID_StandardId"]) : BIDStandardId = null;
		BIDDivisionId = dr["BID_DivisionId"] != DBNull.Value ? Convert.ToInt64(dr["BID_DivisionId"]) : BIDDivisionId = null;
		BIDBookDetailsId = dr["BID_BookDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["BID_BookDetailsId"]) : BIDBookDetailsId = null;
		BIDBookIssuedDate = dr["BID_BookIssuedDate"] != DBNull.Value ? Convert.ToDateTime(dr["BID_BookIssuedDate"]) : BIDBookIssuedDate = null;
		BIDBookSubmitDate = dr["BID_BookSubmitDate"] != DBNull.Value ? Convert.ToDateTime(dr["BID_BookSubmitDate"]) : BIDBookSubmitDate = null;
		BIDBookLateFees = dr["BID_BookLateFees"] != DBNull.Value ? Convert.ToDouble(dr["BID_BookLateFees"]) : BIDBookLateFees = null;
		BIDBookDeposite = dr["BID_BookDeposite"] != DBNull.Value ? Convert.ToDouble(dr["BID_BookDeposite"]) : BIDBookDeposite = null;
		BIDBookOhterCharges = dr["BID_BookOhterCharges"] != DBNull.Value ? Convert.ToDouble(dr["BID_BookOhterCharges"]) : BIDBookOhterCharges = null;
		BIDBookSubmittedStatus = dr["BID_BookSubmittedStatus"] != DBNull.Value ? Convert.ToString(dr["BID_BookSubmittedStatus"]) : BIDBookSubmittedStatus = null;
		BIDBookExtraColumn1 = dr["BID_BookExtraColumn1"] != DBNull.Value ? Convert.ToString(dr["BID_BookExtraColumn1"]) : BIDBookExtraColumn1 = null;
		BIDBookExtraColumn2 = dr["BID_BookExtraColumn2"] != DBNull.Value ? Convert.ToString(dr["BID_BookExtraColumn2"]) : BIDBookExtraColumn2 = null;
		BIDBookExtraColumn3 = dr["BID_BookExtraColumn3"] != DBNull.Value ? Convert.ToString(dr["BID_BookExtraColumn3"]) : BIDBookExtraColumn3 = null;
		BIDBookExtraColumn4 = dr["BID_BookExtraColumn4"] != DBNull.Value ? Convert.ToString(dr["BID_BookExtraColumn4"]) : BIDBookExtraColumn4 = null;
		BIDBookExtraFees1 = dr["BID_BookExtraFees1"] != DBNull.Value ? Convert.ToDouble(dr["BID_BookExtraFees1"]) : BIDBookExtraFees1 = null;
		BIDBookExtraFees2 = dr["BID_BookExtraFees2"] != DBNull.Value ? Convert.ToDouble(dr["BID_BookExtraFees2"]) : BIDBookExtraFees2 = null;
		BIDBookExtraDate1 = dr["BID_BookExtraDate1"] != DBNull.Value ? Convert.ToDateTime(dr["BID_BookExtraDate1"]) : BIDBookExtraDate1 = null;
		BIDBookExtraDate2 = dr["BID_BookExtraDate2"] != DBNull.Value ? Convert.ToDateTime(dr["BID_BookExtraDate2"]) : BIDBookExtraDate2 = null;
		BIDStatus = dr["BID_Status"] != DBNull.Value ? Convert.ToBoolean(dr["BID_Status"]) : BIDStatus = null;
	}
	
	public static TMSBookIssuedDetails[] MapFrom(DataSet ds)
	{
		List<TMSBookIssuedDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBookIssuedDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BookIssuedDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BookIssuedDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBookIssuedDetails instance = new TMSBookIssuedDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBookIssuedDetails Get(System.Int64 bidBookId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBookIssuedDetails instance;
		
		
		instance = new TMSBookIssuedDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bidBookId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSBookIssuedDetails ID:" + bidBookId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate, System.Double? bidBookLateFees, System.Double? bidBookDeposite, System.Double? bidBookOhterCharges, System.String bidBookSubmittedStatus, System.String bidBookExtraColumn1, System.String bidBookExtraColumn2, System.String bidBookExtraColumn3, System.String bidBookExtraColumn4, System.Double? bidBookExtraFees1, System.Double? bidBookExtraFees2, System.DateTime? bidBookExtraDate1, System.DateTime? bidBookExtraDate2, System.Boolean? bidStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bidLibraryManagerId, bidUserLoginId, bidSubjectId, bidStandardId, bidDivisionId, bidBookDetailsId, bidBookIssuedDate, bidBookSubmitDate, bidBookLateFees, bidBookDeposite, bidBookOhterCharges, bidBookSubmittedStatus, bidBookExtraColumn1, bidBookExtraColumn2, bidBookExtraColumn3, bidBookExtraColumn4, bidBookExtraFees1, bidBookExtraFees2, bidBookExtraDate1, bidBookExtraDate2, bidStatus);
		
		if (transaction == null)
		this.BIDBookId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BIDBookId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate, System.Double? bidBookLateFees, System.Double? bidBookDeposite, System.Double? bidBookOhterCharges, System.String bidBookSubmittedStatus, System.String bidBookExtraColumn1, System.String bidBookExtraColumn2, System.String bidBookExtraColumn3, System.String bidBookExtraColumn4, System.Double? bidBookExtraFees1, System.Double? bidBookExtraFees2, System.DateTime? bidBookExtraDate1, System.DateTime? bidBookExtraDate2, System.Boolean? bidStatus)
	{
		Insert(bidLibraryManagerId, bidUserLoginId, bidSubjectId, bidStandardId, bidDivisionId, bidBookDetailsId, bidBookIssuedDate, bidBookSubmitDate, bidBookLateFees, bidBookDeposite, bidBookOhterCharges, bidBookSubmittedStatus, bidBookExtraColumn1, bidBookExtraColumn2, bidBookExtraColumn3, bidBookExtraColumn4, bidBookExtraFees1, bidBookExtraFees2, bidBookExtraDate1, bidBookExtraDate2, bidStatus, null);
	}
	/// <summary>
	/// Insert current TMSBookIssuedDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BIDLibraryManagerId, BIDUserLoginId, BIDSubjectId, BIDStandardId, BIDDivisionId, BIDBookDetailsId, BIDBookIssuedDate, BIDBookSubmitDate, BIDBookLateFees, BIDBookDeposite, BIDBookOhterCharges, BIDBookSubmittedStatus, BIDBookExtraColumn1, BIDBookExtraColumn2, BIDBookExtraColumn3, BIDBookExtraColumn4, BIDBookExtraFees1, BIDBookExtraFees2, BIDBookExtraDate1, BIDBookExtraDate2, BIDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBookIssuedDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bidBookId, System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate, System.Double? bidBookLateFees, System.Double? bidBookDeposite, System.Double? bidBookOhterCharges, System.String bidBookSubmittedStatus, System.String bidBookExtraColumn1, System.String bidBookExtraColumn2, System.String bidBookExtraColumn3, System.String bidBookExtraColumn4, System.Double? bidBookExtraFees1, System.Double? bidBookExtraFees2, System.DateTime? bidBookExtraDate1, System.DateTime? bidBookExtraDate2, System.Boolean? bidStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bidBookId"].Value = bidBookId;
		dbCommand.Parameters["@bidLibraryManagerId"].Value = bidLibraryManagerId;
		dbCommand.Parameters["@bidUserLoginId"].Value = bidUserLoginId;
		dbCommand.Parameters["@bidSubjectId"].Value = bidSubjectId;
		dbCommand.Parameters["@bidStandardId"].Value = bidStandardId;
		dbCommand.Parameters["@bidDivisionId"].Value = bidDivisionId;
		dbCommand.Parameters["@bidBookDetailsId"].Value = bidBookDetailsId;
		dbCommand.Parameters["@bidBookIssuedDate"].Value = bidBookIssuedDate;
		dbCommand.Parameters["@bidBookSubmitDate"].Value = bidBookSubmitDate;
		dbCommand.Parameters["@bidBookLateFees"].Value = bidBookLateFees;
		dbCommand.Parameters["@bidBookDeposite"].Value = bidBookDeposite;
		dbCommand.Parameters["@bidBookOhterCharges"].Value = bidBookOhterCharges;
		dbCommand.Parameters["@bidBookSubmittedStatus"].Value = bidBookSubmittedStatus;
		dbCommand.Parameters["@bidBookExtraColumn1"].Value = bidBookExtraColumn1;
		dbCommand.Parameters["@bidBookExtraColumn2"].Value = bidBookExtraColumn2;
		dbCommand.Parameters["@bidBookExtraColumn3"].Value = bidBookExtraColumn3;
		dbCommand.Parameters["@bidBookExtraColumn4"].Value = bidBookExtraColumn4;
		dbCommand.Parameters["@bidBookExtraFees1"].Value = bidBookExtraFees1;
		dbCommand.Parameters["@bidBookExtraFees2"].Value = bidBookExtraFees2;
		dbCommand.Parameters["@bidBookExtraDate1"].Value = bidBookExtraDate1;
		dbCommand.Parameters["@bidBookExtraDate2"].Value = bidBookExtraDate2;
		dbCommand.Parameters["@bidStatus"].Value = bidStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bidBookId, System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate, System.Double? bidBookLateFees, System.Double? bidBookDeposite, System.Double? bidBookOhterCharges, System.String bidBookSubmittedStatus, System.String bidBookExtraColumn1, System.String bidBookExtraColumn2, System.String bidBookExtraColumn3, System.String bidBookExtraColumn4, System.Double? bidBookExtraFees1, System.Double? bidBookExtraFees2, System.DateTime? bidBookExtraDate1, System.DateTime? bidBookExtraDate2, System.Boolean? bidStatus)
	{
		Update(bidBookId, bidLibraryManagerId, bidUserLoginId, bidSubjectId, bidStandardId, bidDivisionId, bidBookDetailsId, bidBookIssuedDate, bidBookSubmitDate, bidBookLateFees, bidBookDeposite, bidBookOhterCharges, bidBookSubmittedStatus, bidBookExtraColumn1, bidBookExtraColumn2, bidBookExtraColumn3, bidBookExtraColumn4, bidBookExtraFees1, bidBookExtraFees2, bidBookExtraDate1, bidBookExtraDate2, bidStatus, null);
	}
	
	public static void Update(TMSBookIssuedDetails tMSBookIssuedDetails)
	{
		tMSBookIssuedDetails.Update();
	}
	
	public static void Update(TMSBookIssuedDetails tMSBookIssuedDetails, DbTransaction transaction)
	{
		tMSBookIssuedDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bidBookId"].SourceColumn = "BID_BookId";
		dbCommand.Parameters["@bidLibraryManagerId"].SourceColumn = "BID_LibraryManagerId";
		dbCommand.Parameters["@bidUserLoginId"].SourceColumn = "BID_UserLoginId";
		dbCommand.Parameters["@bidSubjectId"].SourceColumn = "BID_SubjectId";
		dbCommand.Parameters["@bidStandardId"].SourceColumn = "BID_StandardId";
		dbCommand.Parameters["@bidDivisionId"].SourceColumn = "BID_DivisionId";
		dbCommand.Parameters["@bidBookDetailsId"].SourceColumn = "BID_BookDetailsId";
		dbCommand.Parameters["@bidBookIssuedDate"].SourceColumn = "BID_BookIssuedDate";
		dbCommand.Parameters["@bidBookSubmitDate"].SourceColumn = "BID_BookSubmitDate";
		dbCommand.Parameters["@bidBookLateFees"].SourceColumn = "BID_BookLateFees";
		dbCommand.Parameters["@bidBookDeposite"].SourceColumn = "BID_BookDeposite";
		dbCommand.Parameters["@bidBookOhterCharges"].SourceColumn = "BID_BookOhterCharges";
		dbCommand.Parameters["@bidBookSubmittedStatus"].SourceColumn = "BID_BookSubmittedStatus";
		dbCommand.Parameters["@bidBookExtraColumn1"].SourceColumn = "BID_BookExtraColumn1";
		dbCommand.Parameters["@bidBookExtraColumn2"].SourceColumn = "BID_BookExtraColumn2";
		dbCommand.Parameters["@bidBookExtraColumn3"].SourceColumn = "BID_BookExtraColumn3";
		dbCommand.Parameters["@bidBookExtraColumn4"].SourceColumn = "BID_BookExtraColumn4";
		dbCommand.Parameters["@bidBookExtraFees1"].SourceColumn = "BID_BookExtraFees1";
		dbCommand.Parameters["@bidBookExtraFees2"].SourceColumn = "BID_BookExtraFees2";
		dbCommand.Parameters["@bidBookExtraDate1"].SourceColumn = "BID_BookExtraDate1";
		dbCommand.Parameters["@bidBookExtraDate2"].SourceColumn = "BID_BookExtraDate2";
		dbCommand.Parameters["@bidStatus"].SourceColumn = "BID_Status";
		
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
	public static void Delete(System.Int64? bidBookId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bidBookId);
		
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
	public static void Delete(System.Int64? bidBookId)
	{
		Delete(
		bidBookId);
	}
	
	/// <summary>
	/// Delete current TMSBookIssuedDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BIDBookId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BIDBookId = null;
	}
	
	/// <summary>
	/// Delete current TMSBookIssuedDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBookIssuedDetails[] Search(System.Int64? bidBookId, System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate, System.Double? bidBookLateFees, System.Double? bidBookDeposite, System.Double? bidBookOhterCharges, System.String bidBookSubmittedStatus, System.String bidBookExtraColumn1, System.String bidBookExtraColumn2, System.String bidBookExtraColumn3, System.String bidBookExtraColumn4, System.Double? bidBookExtraFees1, System.Double? bidBookExtraFees2, System.DateTime? bidBookExtraDate1, System.DateTime? bidBookExtraDate2, System.Boolean? bidStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookIssuedDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bidBookId, bidLibraryManagerId, bidUserLoginId, bidSubjectId, bidStandardId, bidDivisionId, bidBookDetailsId, bidBookIssuedDate, bidBookSubmitDate, bidBookLateFees, bidBookDeposite, bidBookOhterCharges, bidBookSubmittedStatus, bidBookExtraColumn1, bidBookExtraColumn2, bidBookExtraColumn3, bidBookExtraColumn4, bidBookExtraFees1, bidBookExtraFees2, bidBookExtraDate1, bidBookExtraDate2, bidStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBookIssuedDetails.MapFrom(ds);
	}
	
	
	public static TMSBookIssuedDetails[] Search(TMSBookIssuedDetails searchObject)
	{
		return Search ( searchObject.BIDBookId, searchObject.BIDLibraryManagerId, searchObject.BIDUserLoginId, searchObject.BIDSubjectId, searchObject.BIDStandardId, searchObject.BIDDivisionId, searchObject.BIDBookDetailsId, searchObject.BIDBookIssuedDate, searchObject.BIDBookSubmitDate, searchObject.BIDBookLateFees, searchObject.BIDBookDeposite, searchObject.BIDBookOhterCharges, searchObject.BIDBookSubmittedStatus, searchObject.BIDBookExtraColumn1, searchObject.BIDBookExtraColumn2, searchObject.BIDBookExtraColumn3, searchObject.BIDBookExtraColumn4, searchObject.BIDBookExtraFees1, searchObject.BIDBookExtraFees2, searchObject.BIDBookExtraDate1, searchObject.BIDBookExtraDate2, searchObject.BIDStatus);
	}
	
	/// <summary>
	/// Returns all TMSBookIssuedDetails objects.
	/// </summary>
	/// <returns>List of all TMSBookIssuedDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBookIssuedDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

