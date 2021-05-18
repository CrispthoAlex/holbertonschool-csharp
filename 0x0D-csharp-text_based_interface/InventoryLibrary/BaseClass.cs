using System;

class BaseClass
{
    string id;
    DateTime date_created;
    DateTime date_updated;

    /// <summary> BaseClass constructor </summary>
    public BaseClass()
    {
        id = Guid.NewGuid().ToString();
        date_created = DateTime.Now;
        date_updated = date_created;
    }
}
