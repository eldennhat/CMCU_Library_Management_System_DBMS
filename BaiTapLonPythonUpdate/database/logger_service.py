import pymongo
from datetime import datetime



class SystemLog:
    def __init__(self):
        # connect to MongoDB
        # default localhost:27017
        try:
            self.client = pymongo.MongoClient("mongodb://localhost:27017")
            #choose a database and collection
            self.db = self.client["LibraryDB"]
            self.collection = self.db["system_logs"]
            print("MongoDB Connected")
        except Exception as e:
            print(f"Error connecting to MongoDB: {e}")
    def insert_log(self, username, action, message, detail = None):
        #insert log to mongoDB
        log_data = {
            "username": username,
            "action": action,
            "message": message,
            "detail": detail if detail else {},
            "system" : "Library App", #danh dau nguon log
            "time": datetime.now()
        }
        try:
            self.collection.insert_one(log_data)
            print(f"Logged: {action}")
        except Exception as e:
            print(f"Error: {e}")

    def get_history_staff(self, username):
        #tìm tất cả lịch sử hoạt động của một nhân viên cụ thể
        try:
            query = {"username": {"$regex": f"^{username}$", "$options": "i"}}
            ket_qua = self.collection.find(query).sort("time", -1)
            log_list = list(ket_qua)
            return log_list
        except Exception as e:
            print(f"Error: {e}")
            return []
logger = SystemLog()
