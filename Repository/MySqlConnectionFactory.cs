﻿namespace api.Repository;

public class MySqlConnectionFactory
{
    public static MySqlConnection GetConnection()
    {
        const string connectionString = "server=189.50.105.10;" +
                                        "port=3306;" +
                                        "database=db_evento;" +
                                        "uid=user_eventos;" +
                                        "pwd=senai792+;";
        return new MySqlConnection(connectionString);
    }
}