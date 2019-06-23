using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns
{
    class DBConnections {
    private List<SingleConnection> _connections;

    private static DBConnections singletonDBConnections;
    private static object lockObj = new object();

    private DBConnections() {
        this._connections = new List<SingleConnection>();
    }

    public static DBConnections GetInstance() {

        if (singletonDBConnections != null)
                return singletonDBConnections;            

        lock(lockObj)
        {
            if (singletonDBConnections == null)
                singletonDBConnections = new DBConnections();
        }

        return singletonDBConnections;
    }

    public void AddConnection() {
        this._connections.Add(new SingleConnection());
    }

    public void RemoveConnection(int index) {
        this._connections.RemoveAt(index);
    }

    public SingleConnection GetConnection() {
        return this._connections[0];
    }
}   
}