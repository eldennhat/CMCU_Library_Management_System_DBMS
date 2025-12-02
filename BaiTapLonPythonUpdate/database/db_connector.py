import pymssql
SQL_SERVER_CONFIG = {
    'server': 'ELDENNHAT',
    'port': '1433',
    'database': 'Lib_Mgmt',
    'username': 'sa',
    'password': 'Eldennhat0207'
}

#-------Kết nối sql
def get_db_connection():
    try:
        #hàm để trả về database kết nối
        conn = pymssql.connect(
            server = SQL_SERVER_CONFIG['server'],
            port = int(SQL_SERVER_CONFIG['port']),
            user = SQL_SERVER_CONFIG['username'],
            password = SQL_SERVER_CONFIG['password'],
            database = SQL_SERVER_CONFIG['database']
        )
        return conn
    except pymssql.Error as e:
        print(f"Lỗi kết nối với SQL Server: {e}")
        return None

if __name__ == "__main__":
    conn = get_db_connection()
    if conn:
        print("Kết nối thành công!")
        cursor = conn.cursor()
        cursor.execute("SELECT @@VERSION")
        version = cursor.fetchone()
        print(f"SQL Server version: {version[0][:50]}...")
        conn.close()
    else:
        print("Kết nối thất bại!")
