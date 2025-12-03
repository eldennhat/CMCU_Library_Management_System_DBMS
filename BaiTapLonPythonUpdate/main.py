import tkinter as tk

from tkinter import messagebox

from database.logger_service import logger
from GUI.Menu.LOGIN.MenuLogin import LoginView
from GUI.Menu.ADMIN.AdminMenu import AdminMenu
from GUI.Menu.LIBRARIAN.LibrarianMenu import LibrarianMenu

class MainApplication(tk.Tk):
    def __init__(self):
        super().__init__() #là mảnh đất chính để xây dựng ra các frame login, admin...
        self.title("Hệ thống quản lý thư viện")
        self.geometry("800x500")
        self.resizable(width=False, height=False)

        self.current_frame = None #Frame đang được hiển thị

        self.show_login_view()

    def show_login_view(self):
        if self.current_frame:
            self.current_frame.destroy()
        self.current_frame = LoginView(self, on_login_callback= self.on_login_success)
        self.title("Ứng dụng Quản lý thư viện ")
        self.geometry("600x400")
        self.resizable(False, False)

    def on_login_success(self, username, role):
        self.current_user = username
        print(f"Đang tìm nhật ký của: {username}")

        # Gọi hàm lấy lịch sử từ logger
        danh_sach = logger.get_history_staff(username)
        if len(danh_sach) > 0:
            for log in danh_sach:
                thoi_gian = log.get("time").strftime("%H:%M:%S %d/%m/%Y")
                hanh_dong = log.get("action")
                trang_thai = log.get("status", "Info")
                thong_diep = log.get("message")
                print(f"{hanh_dong}:[{thoi_gian}] - {trang_thai}: {thong_diep}")
        else:
            print("Không tìm thấy lịch sử hoạt động nào.")
        # -------------------------------------------------------

        if role == "Admin":
            self.show_admin_menu() #Hàm hiển thị admin ở dưới
        elif role == "Librarian":
            self.show_librarian_view() #Hàm hiển thị Thủ thư
        else:
            messagebox.showwarning("Lỗi vai trò không xác định")

    def show_admin_menu(self): #Hiển thị frame Admin
        if self.current_frame:
            self.current_frame.destroy()
        self.current_frame = AdminMenu(self)

        self.geometry("1000x800")
        self.title("Admin")
        self.resizable(False, False)

    def show_librarian_view(self):
        if self.current_frame:
            self.current_frame.destroy()
        self.current_frame = LibrarianMenu(self)

        self.geometry("1000x800")
        self.title("Thủ thư")
        self.resizable(False, False)

if __name__ == "__main__": #Điểm khởi chạy
    app = MainApplication()
    app.mainloop()

