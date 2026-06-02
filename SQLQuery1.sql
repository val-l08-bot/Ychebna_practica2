update u
set u.id_role=r.id_role
from Users u
inner join Roles r on u.id_role = r.role_name