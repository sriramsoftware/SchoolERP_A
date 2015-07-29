using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSRoyaltyMonthlyCharges
{   
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? rdRoyaltyId, System.String rdMonth, System.String rdYear, System.String rdTutionFees, System.String rdDayCareCharges, System.String rdMealCharges, System.String rdTransportationCharges, System.String rdActivityCharges, System.String rdMisExpenses, System.String rdnttFees, System.String rdctetCoaching, System.String rdForeignLanFees, System.Int64? rdAddedById, System.String rdAddedByType, System.DateTime? rdDate, System.Int32? rdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRoyaltyMonthlyCharges_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, rdRoyaltyId, rdMonth, rdYear, rdTutionFees, rdDayCareCharges, rdMealCharges, rdTransportationCharges, rdActivityCharges, rdMisExpenses, rdnttFees, rdctetCoaching, rdForeignLanFees, rdAddedById, rdAddedByType, rdDate, rdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
        return ds;
	}


    public static DataSet GetSearch(TMSRoyaltyMonthlyCharges searchObject)
	{
        return GetSearch(searchObject.RDRoyaltyId, searchObject.RDMonth, searchObject.RDYear, searchObject.RDTutionFees, searchObject.RDDayCareCharges, searchObject.RDMealCharges, searchObject.RDTransportationCharges, searchObject.RDActivityCharges, searchObject.RDMisExpenses, searchObject.RDNTTFees, searchObject.RDCTETCoaching, searchObject.RDForeignLanFees, searchObject.RDAddedById, searchObject.RDAddedByType, searchObject.RDDate, searchObject.RDStatus);
	}
	
	/// <summary>
	/// Returns all TMSRoyaltyMonthlyCharges objects.
	/// </summary>
	/// <returns>List of all TMSRoyaltyMonthlyCharges objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
	{
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion

    public static DataSet GetSearchMonthlyRoyalty(System.String rdMonth, System.String rdYear)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSSearchMonthlyRoyalty";
        dbCommand = db.GetStoredProcCommand(sqlCommand, rdMonth, rdYear);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

