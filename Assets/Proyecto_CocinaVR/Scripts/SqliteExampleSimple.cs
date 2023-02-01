
using Mono.Data.Sqlite; // 1
using System.Data; // 1
using UnityEngine;


public class SqliteExampleSimple : MonoBehaviour
{
    // Resources:
    // https://www.mono-project.com/docs/database-access/providers/sqlite/

    [SerializeField] private int hitCount = 0;
    [SerializeField] private float conteo = 0;
    private bool enable = false;

    void Start() // 13
    {
        // Recupera valor hits almacenado en la base de datos
        IDbConnection dbConnection = CreateAndOpenDatabase(); // Abrir conexion Base de datos
        IDbCommand dbCommandReadValues = dbConnection.CreateCommand(); // 15
        dbCommandReadValues.CommandText = "SELECT * FROM HitCountTableSimple"; // 16
        IDataReader dataReader = dbCommandReadValues.ExecuteReader(); // 17
        while (dataReader.Read()) // 18
        {
            // The `id` has index 0, our `hits` have the index 1.
            hitCount = dataReader.GetInt32(1); // 19
        }

        // Remember to always close the connection at the end.
        dbConnection.Close(); // 20
    }

   // if(Input.) 
    public void Update(){
        
        if (enable){
            conteo += Time.deltaTime;
        }

    }
    //Funcion que se activa cada que clickeas el objeto acredor del script
    private void OnMouseDown()
    {
        if(Input.GetMouseButton()){
            Debug.Log("Holaxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
        enable = true;
        hitCount++;
        // Insert hits into the table.
        IDbConnection dbConnection = CreateAndOpenDatabase(); // 2
        IDbCommand dbCommandInsertValue = dbConnection.CreateCommand(); // 9
        dbCommandInsertValue.CommandText = "INSERT OR REPLACE INTO HitCountTableSimple (id, hits) VALUES (0, " + hitCount + ")"; // 10
        dbCommandInsertValue.ExecuteNonQuery(); // Ejecutar instruccion de Actualizar

        // Remember to always close the connection at the end.
        dbConnection.Close(); // cerrar la base de datos
    
    }

    private void OnMouseUp(){
        enable = false;
        Debug.Log("Ya");
    }

    private IDbConnection CreateAndOpenDatabase() // 3
    {

        // Open a connection to the database.
        string dbUri = "URI=file:Assets\\DB\\Database"; // Definir nombre de la base de datos
        IDbConnection dbConnection = new SqliteConnection(dbUri); // Crear una conexion a una base de datos
        dbConnection.Open(); // Abrir la conexion con la base de datos
        // Crear una tabla para el conteo de clicks si no existe
        IDbCommand dbCommandCreateTable = dbConnection.CreateCommand(); // Acceder a la base de datps
        //Debug.Log("3");
        dbCommandCreateTable.CommandText = "CREATE TABLE IF NOT EXISTS HitCountTableSimple (id INTEGER PRIMARY KEY, hits INTEGER )"; // 7
        dbCommandCreateTable.ExecuteReader(); // Ejecutar instruccion de creacion
        
        return dbConnection;
    }
}