﻿Select * from tours where (CName like 'Франция') and (CName in (Select Name from Country where Visa like 1)) and (HName in (Select Name from Hotel where Stars >= 1))