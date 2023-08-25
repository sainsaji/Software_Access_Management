import os
import tkinter as tk
from tkinter import filedialog
from tkinter import ttk
from PIL import Image, ImageTk

class ImageResizerApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Image Resizer")

        self.folder_path = ""
        self.progress_var = tk.DoubleVar()
        self.progress_var.set(0.0)

        self.label = tk.Label(self.root, text="Select a folder containing .png files:")
        self.label.grid(row=0, column=0, columnspan=2, pady=10)

        self.browse_button = tk.Button(self.root, text="Browse", command=self.browse_folder)
        self.browse_button.grid(row=1, column=0, pady=5, padx=10)

        self.resize_button = tk.Button(self.root, text="Resize Images", state=tk.DISABLED, command=self.resize_images)
        self.resize_button.grid(row=1, column=1, pady=5, padx=10)

        self.progress_bar = ttk.Progressbar(self.root, variable=self.progress_var, maximum=100)
        self.progress_bar.grid(row=2, column=0, columnspan=2, pady=5, padx=10, sticky="ew")

        self.image_frame = tk.Frame(self.root)
        self.image_frame.grid(row=3, column=0, columnspan=2, pady=10)

        self.images = []
        self.labels = []

    def browse_folder(self):
        self.folder_path = filedialog.askdirectory()
        if self.folder_path:
            self.resize_button.config(state=tk.NORMAL)

    def resize_images(self):
        resized_folder = os.path.join(self.folder_path, "Resized Icons")
        os.makedirs(resized_folder, exist_ok=True)

        png_files = [f for f in os.listdir(self.folder_path) if f.lower().endswith(".png")]

        total_files = len(png_files)
        for index, png_file in enumerate(png_files):
            original_path = os.path.join(self.folder_path, png_file)
            resized_path = os.path.join(resized_folder, png_file)

            if not os.path.exists(resized_path):
                original_image = Image.open(original_path)
                resized_image = original_image.resize((16, 16))
                resized_image.save(resized_path)

            progress = (index + 1) / total_files * 100
            self.progress_var.set(progress)
            self.root.update()

        self.show_resized_images()

    def show_resized_images(self):
        resized_folder = os.path.join(self.folder_path, "Resized Icons")
        png_files = [f for f in os.listdir(resized_folder) if f.lower().endswith(".png")]

        for label in self.labels:
            label.destroy()

        self.labels = []

        row = 0
        col = 0
        for png_file in png_files:
            resized_image = Image.open(os.path.join(resized_folder, png_file))
            resized_image.thumbnail((100, 100))
            photo = ImageTk.PhotoImage(resized_image)

            label = tk.Label(self.image_frame, image=photo)
            label.image = photo
            label.grid(row=row, column=col, padx=5, pady=5, sticky="w")

            details_label = tk.Label(self.image_frame, text=png_file, anchor="w")
            details_label.grid(row=row+1, column=col, padx=5, pady=2, sticky="w")

            self.images.append(photo)
            self.labels.append(label)

            col += 1
            if col > 2:
                col = 0
                row += 2

        self.progress_var.set(0.0)
        self.root.update()

if __name__ == "__main__":
    root = tk.Tk()
    app = ImageResizerApp(root)
    root.mainloop()
