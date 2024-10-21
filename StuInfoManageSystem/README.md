# 基于ASP.NET Core 的学生信息管理系统

## 1.环境配置

### 1.1开发工具包

1. dotnet-ef可以在后续开发中为数据库迁移和创建数据库做准备。

```
dotnet tool install --global dotnet-ef
dotnet-ef
```

2. Microsoft.EntityFrameworkCore.Sqlite是一个包含Sqlite数据库的EF Core框架包。

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

3. Microsoft.AspNetCore.Identity.EntityFrameworkCore将 ASP.NET Core Identity 与 Entity Framework Core 集成，提供用于管理用户、角色和其他身份验证相关数据的默认实现。

```cmd
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```

4. Microsoft.EntityFrameworkCore.Design用于生成迁移文件将模型类映射到数据库表。

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

> 需要注意的是，3个包的版本及dotnet-ef的版本需要保持一致，否则可能会出现错误。

### 1.2前端开发包

- **bulma**：CSS框架
- **sweetalert2**：弹窗库
- **htmx.js**：一个轻量级的 JavaScript 库，通过在 HTML 中使用属性来实现 AJAX 请求等功能

## 2.页面展示

### 2.1登录页面

![image-20241021092752050](./assets/image-20241021092752050.png)

### 2.2管理员首页

![image-20241021093309521](./assets/image-20241021093309521.png)

### 2.3教师首页

![image-20241021093321044](./assets/image-20241021093321044.png)

### 2.4专业管理页面

![image-20241021093410846](./assets/image-20241021093410846.png)

### 2.5年级管理页面

![image-20241021093549508](./assets/image-20241021093549508.png)

### 2.6班级管理页面

![image-20241021093558724](./assets/image-20241021093558724.png)

### 2.7学生管理页面

![image-20241021093607650](./assets/image-20241021093607650.png)

### 2.8专业添加和编辑页面

![image-20241021093729146](./assets/image-20241021093729146.png)

![image-20241021093755502](./assets/image-20241021093755502.png)

### 2.9年级添加和编辑页面

![image-20241021093836238](./assets/image-20241021093836238.png)

![image-20241021093844995](./assets/image-20241021093844995.png)

### 2.10班级添加和编辑页面

![image-20241021093928568](./assets/image-20241021093928568.png)

![image-20241021093935871](./assets/image-20241021093935871.png)

### 2.11学生添加和编辑页面

![image-20241021093957074](./assets/image-20241021093957074.png)

![image-20241021094004504](./assets/image-20241021094004504.png)

### 2.12非法删除专业弹窗

![image-20241021094704236](./assets/image-20241021094704236.png)

### 2.13非法删除年级弹窗

![image-20241021094728748](./assets/image-20241021094728748.png)

### 2.14非法删除班级弹窗

![image-20241021094800939](./assets/image-20241021094800939.png)

### 2.15成功删除学生弹窗

![image-20241021094913359](./assets/image-20241021094913359.png)
