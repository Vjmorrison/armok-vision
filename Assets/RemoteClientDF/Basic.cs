//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Basic.proto
namespace dfproto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EnumItemName")]
  public partial class EnumItemName : global::ProtoBuf.IExtensible
  {
    public EnumItemName() {}
    
    private int _value;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private int _bit_size = (int)1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bit_size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int bit_size
    {
      get { return _bit_size; }
      set { _bit_size = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicMaterialId")]
  public partial class BasicMaterialId : global::ProtoBuf.IExtensible
  {
    public BasicMaterialId() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _index;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicMaterialInfo")]
  public partial class BasicMaterialInfo : global::ProtoBuf.IExtensible
  {
    public BasicMaterialInfo() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _index;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private string _token;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _flags = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> flags
    {
      get { return _flags; }
    }
  

    private int _subtype = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"subtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int subtype
    {
      get { return _subtype; }
      set { _subtype = value; }
    }

    private int _creature_id = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"creature_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int creature_id
    {
      get { return _creature_id; }
      set { _creature_id = value; }
    }

    private int _plant_id = (int)-1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"plant_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int plant_id
    {
      get { return _plant_id; }
      set { _plant_id = value; }
    }

    private int _histfig_id = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"histfig_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int histfig_id
    {
      get { return _histfig_id; }
      set { _histfig_id = value; }
    }

    private string _name_prefix = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"name_prefix", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name_prefix
    {
      get { return _name_prefix; }
      set { _name_prefix = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _state_color = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"state_color", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<uint> state_color
    {
      get { return _state_color; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _state_name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(11, Name=@"state_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> state_name
    {
      get { return _state_name; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _state_adj = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(12, Name=@"state_adj", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> state_adj
    {
      get { return _state_adj; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _reaction_class = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(13, Name=@"reaction_class", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> reaction_class
    {
      get { return _reaction_class; }
    }
  
    private readonly global::System.Collections.Generic.List<dfproto.BasicMaterialInfo.Product> _reaction_product = new global::System.Collections.Generic.List<dfproto.BasicMaterialInfo.Product>();
    [global::ProtoBuf.ProtoMember(14, Name=@"reaction_product", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dfproto.BasicMaterialInfo.Product> reaction_product
    {
      get { return _reaction_product; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _inorganic_flags = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(15, Name=@"inorganic_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> inorganic_flags
    {
      get { return _inorganic_flags; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Product")]
  public partial class Product : global::ProtoBuf.IExtensible
  {
    public Product() {}
    
    private string _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _index;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicMaterialInfoMask")]
  public partial class BasicMaterialInfoMask : global::ProtoBuf.IExtensible
  {
    public BasicMaterialInfoMask() {}
    
    private readonly global::System.Collections.Generic.List<dfproto.BasicMaterialInfoMask.StateType> _states = new global::System.Collections.Generic.List<dfproto.BasicMaterialInfoMask.StateType>();
    [global::ProtoBuf.ProtoMember(1, Name=@"states", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<dfproto.BasicMaterialInfoMask.StateType> states
    {
      get { return _states; }
    }
  

    private int _temperature = (int)10015;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"temperature", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)10015)]
    public int temperature
    {
      get { return _temperature; }
      set { _temperature = value; }
    }

    private bool _flags = (bool)false;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool flags
    {
      get { return _flags; }
      set { _flags = value; }
    }

    private bool _reaction = (bool)false;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"reaction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool reaction
    {
      get { return _reaction; }
      set { _reaction = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"StateType")]
    public enum StateType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Solid", Value=0)]
      Solid = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Liquid", Value=1)]
      Liquid = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Gas", Value=2)]
      Gas = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Powder", Value=3)]
      Powder = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Paste", Value=4)]
      Paste = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Pressed", Value=5)]
      Pressed = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JobSkillAttr")]
  public partial class JobSkillAttr : global::ProtoBuf.IExtensible
  {
    public JobSkillAttr() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private string _caption = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"caption", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caption
    {
      get { return _caption; }
      set { _caption = value; }
    }

    private string _caption_noun = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"caption_noun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caption_noun
    {
      get { return _caption_noun; }
      set { _caption_noun = value; }
    }

    private int _profession = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"profession", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int profession
    {
      get { return _profession; }
      set { _profession = value; }
    }

    private int _labor = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"labor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int labor
    {
      get { return _labor; }
      set { _labor = value; }
    }

    private string _type = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProfessionAttr")]
  public partial class ProfessionAttr : global::ProtoBuf.IExtensible
  {
    public ProfessionAttr() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private string _caption = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"caption", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caption
    {
      get { return _caption; }
      set { _caption = value; }
    }

    private bool _military = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"military", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool military
    {
      get { return _military; }
      set { _military = value; }
    }

    private bool _can_assign_labor = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"can_assign_labor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool can_assign_labor
    {
      get { return _can_assign_labor; }
      set { _can_assign_labor = value; }
    }

    private int _parent = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"parent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int parent
    {
      get { return _parent; }
      set { _parent = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnitLaborAttr")]
  public partial class UnitLaborAttr : global::ProtoBuf.IExtensible
  {
    public UnitLaborAttr() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private string _caption = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"caption", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caption
    {
      get { return _caption; }
      set { _caption = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NameInfo")]
  public partial class NameInfo : global::ProtoBuf.IExtensible
  {
    public NameInfo() {}
    

    private string _first_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"first_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string first_name
    {
      get { return _first_name; }
      set { _first_name = value; }
    }

    private string _nickname = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }

    private int _language_id = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"language_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int language_id
    {
      get { return _language_id; }
      set { _language_id = value; }
    }

    private string _last_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"last_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string last_name
    {
      get { return _last_name; }
      set { _last_name = value; }
    }

    private string _english_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"english_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string english_name
    {
      get { return _english_name; }
      set { _english_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NameTriple")]
  public partial class NameTriple : global::ProtoBuf.IExtensible
  {
    public NameTriple() {}
    
    private string _normal;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"normal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string normal
    {
      get { return _normal; }
      set { _normal = value; }
    }

    private string _plural = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"plural", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string plural
    {
      get { return _plural; }
      set { _plural = value; }
    }

    private string _adjective = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"adjective", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string adjective
    {
      get { return _adjective; }
      set { _adjective = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnitCurseInfo")]
  public partial class UnitCurseInfo : global::ProtoBuf.IExtensible
  {
    public UnitCurseInfo() {}
    
    private uint _add_tags1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"add_tags1", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint add_tags1
    {
      get { return _add_tags1; }
      set { _add_tags1 = value; }
    }
    private uint _rem_tags1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"rem_tags1", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint rem_tags1
    {
      get { return _rem_tags1; }
      set { _rem_tags1 = value; }
    }
    private uint _add_tags2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"add_tags2", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint add_tags2
    {
      get { return _add_tags2; }
      set { _add_tags2 = value; }
    }
    private uint _rem_tags2;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"rem_tags2", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint rem_tags2
    {
      get { return _rem_tags2; }
      set { _rem_tags2 = value; }
    }

    private dfproto.NameTriple _name = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dfproto.NameTriple name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillInfo")]
  public partial class SkillInfo : global::ProtoBuf.IExtensible
  {
    public SkillInfo() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _experience;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"experience", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int experience
    {
      get { return _experience; }
      set { _experience = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnitMiscTrait")]
  public partial class UnitMiscTrait : global::ProtoBuf.IExtensible
  {
    public UnitMiscTrait() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _value;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicUnitInfo")]
  public partial class BasicUnitInfo : global::ProtoBuf.IExtensible
  {
    public BasicUnitInfo() {}
    
    private int _unit_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unit_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int unit_id
    {
      get { return _unit_id; }
      set { _unit_id = value; }
    }
    private int _pos_x;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"pos_x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pos_x
    {
      get { return _pos_x; }
      set { _pos_x = value; }
    }
    private int _pos_y;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"pos_y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pos_y
    {
      get { return _pos_y; }
      set { _pos_y = value; }
    }
    private int _pos_z;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"pos_z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pos_z
    {
      get { return _pos_z; }
      set { _pos_z = value; }
    }

    private dfproto.NameInfo _name = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dfproto.NameInfo name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _flags1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"flags1", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint flags1
    {
      get { return _flags1; }
      set { _flags1 = value; }
    }
    private uint _flags2;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"flags2", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint flags2
    {
      get { return _flags2; }
      set { _flags2 = value; }
    }
    private uint _flags3;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"flags3", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint flags3
    {
      get { return _flags3; }
      set { _flags3 = value; }
    }
    private int _race;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"race", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int race
    {
      get { return _race; }
      set { _race = value; }
    }
    private int _caste;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"caste", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int caste
    {
      get { return _caste; }
      set { _caste = value; }
    }

    private int _gender = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int gender
    {
      get { return _gender; }
      set { _gender = value; }
    }

    private int _civ_id = (int)-1;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"civ_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int civ_id
    {
      get { return _civ_id; }
      set { _civ_id = value; }
    }

    private int _histfig_id = (int)-1;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"histfig_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int histfig_id
    {
      get { return _histfig_id; }
      set { _histfig_id = value; }
    }

    private int _death_id = (int)-1;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"death_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int death_id
    {
      get { return _death_id; }
      set { _death_id = value; }
    }

    private uint _death_flags = default(uint);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"death_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint death_flags
    {
      get { return _death_flags; }
      set { _death_flags = value; }
    }

    private int _squad_id = (int)-1;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"squad_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int squad_id
    {
      get { return _squad_id; }
      set { _squad_id = value; }
    }

    private int _squad_position = (int)-1;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"squad_position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int squad_position
    {
      get { return _squad_position; }
      set { _squad_position = value; }
    }

    private int _profession = (int)-1;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"profession", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int profession
    {
      get { return _profession; }
      set { _profession = value; }
    }

    private string _custom_profession = "";
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"custom_profession", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string custom_profession
    {
      get { return _custom_profession; }
      set { _custom_profession = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _labors = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(11, Name=@"labors", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> labors
    {
      get { return _labors; }
    }
  
    private readonly global::System.Collections.Generic.List<dfproto.SkillInfo> _skills = new global::System.Collections.Generic.List<dfproto.SkillInfo>();
    [global::ProtoBuf.ProtoMember(12, Name=@"skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dfproto.SkillInfo> skills
    {
      get { return _skills; }
    }
  
    private readonly global::System.Collections.Generic.List<dfproto.UnitMiscTrait> _misc_traits = new global::System.Collections.Generic.List<dfproto.UnitMiscTrait>();
    [global::ProtoBuf.ProtoMember(24, Name=@"misc_traits", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dfproto.UnitMiscTrait> misc_traits
    {
      get { return _misc_traits; }
    }
  

    private dfproto.UnitCurseInfo _curse = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"curse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dfproto.UnitCurseInfo curse
    {
      get { return _curse; }
      set { _curse = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _burrows = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(21, Name=@"burrows", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> burrows
    {
      get { return _burrows; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicUnitInfoMask")]
  public partial class BasicUnitInfoMask : global::ProtoBuf.IExtensible
  {
    public BasicUnitInfoMask() {}
    

    private bool _labors = (bool)false;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"labors", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool labors
    {
      get { return _labors; }
      set { _labors = value; }
    }

    private bool _skills = (bool)false;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool skills
    {
      get { return _skills; }
      set { _skills = value; }
    }

    private bool _profession = (bool)false;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"profession", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool profession
    {
      get { return _profession; }
      set { _profession = value; }
    }

    private bool _misc_traits = (bool)false;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"misc_traits", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool misc_traits
    {
      get { return _misc_traits; }
      set { _misc_traits = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicSquadInfo")]
  public partial class BasicSquadInfo : global::ProtoBuf.IExtensible
  {
    public BasicSquadInfo() {}
    
    private int _squad_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"squad_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int squad_id
    {
      get { return _squad_id; }
      set { _squad_id = value; }
    }

    private dfproto.NameInfo _name = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public dfproto.NameInfo name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _alias = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"alias", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string alias
    {
      get { return _alias; }
      set { _alias = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _members = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"members", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> members
    {
      get { return _members; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnitLaborState")]
  public partial class UnitLaborState : global::ProtoBuf.IExtensible
  {
    public UnitLaborState() {}
    
    private int _unit_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unit_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int unit_id
    {
      get { return _unit_id; }
      set { _unit_id = value; }
    }
    private int _labor;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"labor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int labor
    {
      get { return _labor; }
      set { _labor = value; }
    }
    private bool _value;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}