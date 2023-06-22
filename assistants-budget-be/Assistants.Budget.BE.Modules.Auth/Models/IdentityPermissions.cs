﻿namespace Assistants.Budget.BE.Modules.Auth.Models;

public static class IdentityPermissions
{
    public const string TransactionCanCreate = "transaction:create";
    public const string TransactionCanRead = "transaction:read";
    public const string TransactionCanDelete = "transaction:delete";
    public const string TransactionCanEdit = "transaction:edit";

    public const string RoleCanCreate = "role:create";
    public const string RoleCanEdit = "role:edit";
    public const string RoleCanRead = "role:read";
    public const string RoleCanDelete = "role:delete";

    public const string UserCanCreate = "user:create";
    public const string UserCanEdit = "user:edit";
    public const string UserCanRead = "user:read";
    public const string UserCanDelete = "user:delete";
}
