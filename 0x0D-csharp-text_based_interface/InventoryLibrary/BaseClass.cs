using System;

class BaseClass
{
    /// <summary> id property </summary>
    string id {get; set;};
    /// <summary> Date created property </summary>
    DateTime date_created {get; set;};
    /// <summary> Date updated property </summary>
    DateTime date_updated {get; set;};

    /// <summary> BaseClass constructor </summary>
    public BaseClass()
    {
        id = Guid.NewGuid().ToString();
        date_created = DateTime.Now;
        date_updated = date_created;
    }

    /// <summary> Serializes the object </summary>
    public string ToJSON()
    {
        var options = new JsonSerializerOptions { WriteIndented = true,};
        return JsonSerializer.Serialize<Object>(this, options);
    }

    /// <summary> String representation of this object </summary>
    public override string ToString() => $"[{this.GetType().Name}] ({this.id}) \n{ToJSON()}";

}
