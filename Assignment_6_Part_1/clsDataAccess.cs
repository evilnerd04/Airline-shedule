using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
//This class was taken from the in-class code given by Prof. Crowder


/// <summary>
/// Class used to access the database.
/// </summary>
public class clsDataAccess
{
    /// <summary>
    /// Connection string to the database.
    /// </summary>
    private string sConnectionString;

    /// <summary>
    /// Constructor that sets the connection string to the database
    /// </summary>
    public clsDataAccess()
    {
        sConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source= " + Directory.GetCurrentDirectory() + "\\ReservationSystem.mdb";
    }

    /// <summary>
    /// This method takes an SQL statement that is passed in and executes it.  The resulting values
    /// are returned in a DataSet.  The number of rows returned from the query will be put into
    /// the reference parameter iRetVal.
    /// </summary>
    /// <param name="sSQL">The SQL statement to be executed.</param>
    /// <param name="iRetVal">Reference parameter that returns the number of selected rows.</param>
    /// <returns>Returns a DataSet that contains the data from the SQL statement.</returns>
    public DataSet ExecuteSQLStatement(string sSQL, ref int iRetVal)
    {
        try
        {
            //Create a new DataSet
            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(sConnectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter())
                {

                    //Open the connection to the database
                    conn.Open();

                    //Add the information for the SelectCommand using the SQL statement and the connection object
                    adapter.SelectCommand = new OleDbCommand(sSQL, conn);
                    adapter.SelectCommand.CommandTimeout = 0;

                    //Fill up the DataSet with data
                    adapter.Fill(ds);
                }
            }

            //Set the number of values returned
            iRetVal = ds.Tables[0].Rows.Count;

            //return the DataSet
            return ds;
        }
        catch (Exception ex)
        {
            throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
        }
    }

    /// <summary>
    /// This method takes an SQL statement that is passed in and executes it.  The resulting single 
    /// value is returned.
    /// </summary>
    /// <param name="sSQL">The SQL statement to be executed.</param>
    /// <returns>Returns a string from the scalar SQL statement.</returns>
    public string ExecuteScalarSQL(string sSQL)
    {
        try
        {
            //Holds the return value
            object obj;

            using (OleDbConnection conn = new OleDbConnection(sConnectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter())
                {

                    //Open the connection to the database
                    conn.Open();

                    //Add the information for the SelectCommand using the SQL statement and the connection object
                    adapter.SelectCommand = new OleDbCommand(sSQL, conn);
                    adapter.SelectCommand.CommandTimeout = 0;

                    //Execute the scalar SQL statement
                    obj = adapter.SelectCommand.ExecuteScalar();
                }
            }

            //See if the object is null
            if (obj == null)
            {
                //Return a blank
                return "";
            }
            else
            {
                //Return the value
                return obj.ToString();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
        }
    }

    /// <summary>
    /// This method takes an SQL statement that is a non query and executes it.
    /// </summary>
    /// <param name="sSQL">The SQL statement to be executed.</param>
    /// <returns>Returns the number of rows affected by the SQL statement.</returns>
    public int ExecuteNonQuery(string sSQL)
    {
        try
        {
            //Number of rows affected
            int iNumRows;

            using (OleDbConnection conn = new OleDbConnection(sConnectionString))
            {
                //Open the connection to the database
                conn.Open();

                //Add the information for the SelectCommand using the SQL statement and the connection object
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.CommandTimeout = 0;

                //Execute the non query SQL statement
                iNumRows = cmd.ExecuteNonQuery();
            }

            //return the number of rows affected
            return iNumRows;
        }
        catch (Exception ex)
        {
            throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
        }
    }


    public DataSet GetFlightInfo()
    {
        int iRet=0;
       return ExecuteSQLStatement("SELECT * FROM flight", ref iRet);
    }

    public DataSet GetPassengerInfo(int flight)
    {
        int iRet = 0;
        string sSQL = "SELECT PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number " +
              "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
          "WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND " +
          "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
          "FLIGHT.FLIGHT_ID = "+flight;

        return ExecuteSQLStatement(sSQL, ref iRet);
    }

    public void UpdateSeatNum(int flight,int seatNum,int passID)
    {
        
        string sSQL = "UPDATE FLIGHT_PASSENGER_LINK " +
           "SET Seat_Number = '" + seatNum + "' " +
           "WHERE FLIGHT_ID = " + flight + " AND PASSENGER_ID = " + passID;


         ExecuteNonQuery(sSQL);
    }

    public Object GetPassengerID(string first, string last)
    {
        
        string sSQL = "SELECT Passenger_ID from Passenger where First_Name = '" + first + "' AND Last_Name = '" + last + "'";


        return ExecuteScalarSQL(sSQL);
    }

    public void InsertPassenger( int passID, string first, string last)
    {
        
        string sSQL = "INSERT INTO PASSENGER(Passenger_ID, First_Name, Last_Name) VALUES( " + passID + ",'" +first + "','"+ last + "')";


        ExecuteNonQuery(sSQL);
    }
    public void InsertLinkTable(int flight, int seatNum, int passID)
    {
        
        string sSQL = "INSERT INTO Flight_Passenger_Link(Flight_ID, Passenger_ID, Seat_Number) " +
       "VALUES( " + flight + " , " + passID + " , " + seatNum + ")";


        ExecuteNonQuery(sSQL);
    }
    public void DeleteLink(int flight, int passID)
    {
        
        string sSQL = "Delete FROM FLIGHT_PASSENGER_LINK " +
           "WHERE FLIGHT_ID = " + flight + " AND " +
           "PASSENGER_ID = " + passID;


         ExecuteNonQuery(sSQL);
    }
    public void DeletePassenger( int passID)
    {
        
        string sSQL = "Delete FROM PASSENGER " +
    "WHERE PASSENGER_ID = " + passID;


        ExecuteNonQuery(sSQL);
    }


}