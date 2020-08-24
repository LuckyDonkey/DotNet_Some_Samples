# EF.Sqlite.CodeFirst
# 2020-08-24
# luckydonkey

场景：

         Entity Framework6 作为开源的O/RM框架（源码：https://github.com/dotnet/ef6），自身实现了Microsoft SQL Server 提供程序和Microsoft SQL Server Compact Edition 提供程序。同时可使用其他第三方的各种数据库提供程序：Oracle、MySQL、PostgreSQL、SQLite、Salesforce、DB2 和 SQL Server等。

         Entity Framework6 自身实现的Microsoft SQL Server 提供程序可以实现Code First开发，建议先看看这个帖：https://www.cnblogs.com/lucky-donkey/p/13532798.html。

         本文主要介绍Entity Framework6实现SQLite数据库的Code First开发。

         由于Entity Framework6自身未实现SQLite数据库的提供程序，所以要实现SQLite数据库的Code First开发。需要实现两个功能：1、实现SQLite数据库的CRUD操作，2、实现SQLite数据库的迁移（Migration）功能。


博文：https://www.cnblogs.com/lucky-donkey/p/13548017.html

参考：

