import os
import tkinter as tk
from tkinter import filedialog
from tkinter import ttk
from PIL import Image

class ImageResizerApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Image Resizer")

        self.folder_path = ""
        self.progress_var = tk.DoubleVar()
        self.progress_var.set(0.0)

        self.label = tk.Label(self.root, text="Select a folder containing .png files:")
        self.label.pack(pady=10)

        self.browse_button = tk.Button(self.root, text="Browse", command=self.browse_folder)
        self.browse_button.pack(pady=5)

        self.resize_button = tk.Button(self.root, text="Resize Images", state=tk.DISABLED, command=self.resize_images)
        self.resize_button.pack(pady=5)

        self.progress_bar = ttk.Progressbar(self.root, variable=self.progress_var, maximum=100)
        self.progress_bar.pack(pady=5)

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
            original_image = Image.open(os.path.join(self.folder_path, png_file))
            resized_image = original_image.resize((16, 16))  # Corrected line

            resized_path = os.path.join(resized_folder, png_file)
            resized_image.save(resized_path)

            progress = (index + 1) / total_files * 100
            self.progress_var.set(progress)
            self.root.update()

        self.progress_var.set(0.0)
        self.root.update()
        tk.messagebox.showinfo("Complete", "Image resizing complete!")

if __name__ == "__main__":
    root = tk.Tk()
    app = ImageResizerApp(root)
    root.mainloop()
