**C#**:

- C# là ngôn ngữ lập trình thuần hướng đối tượng (purely oriented-object programming languages)
- Sử dụng hệ thống quản lý bộ nhớ của .NET, mọi thứ đều quản lý trong môi trường Garbage Collection để tự động thu gom vùng nhớ khi không còn sử dụng nữa => giúp giảm thiểu việc quản lý bộ nhớ thủ công
- Các dữ liệu nguyên thuỷ như int, float, boolean ... ngoài là kiểu dữ liệu giá trị cũng được coi là đối tượng như các lớp qua box và unboxing theo cách thức quản lý bộ nhớ trong .NET

**Nhược điểm**:

- Dùng GC có thể gây ra độ trễ và giảm hiệu suất so với C/C++
- Một số ứng dụng và game đòi hỏi độ trễ thấp bằng cách tối ưu hoá bộ nhớ tốt nhất, nhưng dùng GC thì nó không cho coder kiểm soát toàn bộ bộ nhớ.
- Ứng dụng mobile của C# phụ thuộc vào Xamarin, nhưng Xamarin không phổ biến nên có thể gây ra không tương thích với các API gốc của IOs và Android => hệ sinh thái không bằng React Native hoặc Flutter
