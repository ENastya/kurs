﻿Select * from tours where (CName in (Select Name from Country where Visa = '+')) and (Cname = 'Франция') and (HName in (Select Name from Hotel where Stars >2))