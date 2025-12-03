
import pymssql


from database.db_connector import get_db_connection
from database.logger_service import logger # import logger


# ===== CÁC HÀM XỬ LÝ ĐỘC GIẢ ======

def get_all_readers():
    """Lấy tất cả độc giả từ CSDL."""
    conn = get_db_connection()
    if not conn:
        return None

    cursor = conn.cursor()
    sql = "SELECT ReaderId, FullName, Phone, Address FROM Reader"

    try:
        cursor.execute(sql)
        rows = cursor.fetchall()
        return rows
    except pymssql.Error as e:
        print(f"Lỗi SQL (get_all_readers): {e}")
        return None
    finally:
        if cursor: cursor.close()
        if conn: conn.close()


def add_reader(full_name, phone, address):
    #Thêm độc giả mới (ReaderId tự tăng)."""
    conn = get_db_connection()
    if not conn:
        return False

    cursor = conn.cursor()
    sql = """INSERT INTO Reader (FullName, Phone, Address)
             VALUES (%s, %s, %s)"""

    try:
        cursor.execute(sql, (full_name, phone, address))
        conn.commit()
        
        # Ghi log
        logger.insert_log(username, "Add Reader", f"Added new reader: {full_name}", 
                          {"phone": phone, "address": address})
        
        return True
    except pymssql.Error as e:
        print(f"Lỗi SQL (add_reader): {e}")
        conn.rollback()
        
        # Ghi log lỗi
        logger.insert_log(username, "Add Reader Failed", f"Failed to add reader {full_name}: {e}")
        
        return False
    finally:
        if cursor: cursor.close()
        if conn: conn.close()


def update_reader(reader_id, full_name, phone, address):
    #Cập nhật thông tin độc giả.
    conn = get_db_connection()
    if not conn:
        return False

    cursor = conn.cursor()
    sql = """UPDATE Reader
             SET FullName=%s, \
                 Phone=%s, \
                 Address=%s
             WHERE ReaderId = %s"""

    try:
        cursor.execute(sql, (full_name, phone, address, reader_id))
        conn.commit()
        
        # Ghi log
        logger.insert_log(username, "Update Reader", f"Updated reader ID {reader_id}", 
                          {"new_name": full_name, "new_phone": phone})
        
        return True
    except pymssql.Error as e:
        print(f"Lỗi SQL (update_reader): {e}")
        conn.rollback()
        
        # Ghi log lỗi
        logger.insert_log(username, "Update Reader Failed", f"Failed to update reader ID {reader_id}: {e}")
        
        return False
    finally:
        if cursor: cursor.close()
        if conn: conn.close()


def delete_reader(reader_id):
    #Xóa độc giả
    conn = get_db_connection()
    if not conn:
        return False

    cursor = conn.cursor()
    sql = "DELETE FROM Reader WHERE ReaderId = %s"

    try:
        cursor.execute(sql, (reader_id,))
        conn.commit()
        
        # Ghi log
        logger.insert_log(username, "Delete Reader", f"Deleted reader ID {reader_id}", {"reader_id": reader_id})
        
        return True
    except pymssql.Error as e:
        # GHI CHÚ: Xử lý lỗi nếu độc giả đang mượn sách (Foreign Key)
        print(f"Lỗi SQL (delete_reader): {e}")
        conn.rollback()
        
        # Ghi log lỗi
        logger.insert_log(username, "Delete Reader Failed", f"Failed to delete reader ID {reader_id}: {e}")
        
        return False
    finally:
        if cursor: cursor.close()
        if conn: conn.close()


def find_reader(search_term):
    #Tìm 1 độc giả bằng FullName hoặc Phone."""
    conn = get_db_connection()
    if not conn:
        return None

    cursor = conn.cursor()
    sql = """
          SELECT ReaderId, FullName, Phone, Address
          FROM Reader
          WHERE FullName LIKE %s \
             OR Phone LIKE %s
          """
    search_pattern = f'%{search_term}%'

    try:
        cursor.execute(sql, (search_pattern, search_pattern))
        row = cursor.fetchall()
        return row
    except pymssql.Error as e:
        print(f"Lỗi SQL (find_reader): {e}")
        return None
    finally:
        if cursor: cursor.close()
        if conn: conn.close()
