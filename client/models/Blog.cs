// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: blog.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Blog {

  /// <summary>Holder for reflection information generated from blog.proto</summary>
  public static partial class BlogReflection {

    #region Descriptor
    /// <summary>File descriptor for blog.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpibG9nLnByb3RvEgRibG9nIkUKBEJsb2cSCgoCaWQYASABKAkSEQoJYXV0",
            "aG9yX2lkGAIgASgJEg0KBXRpdGxlGAMgASgJEg8KB2NvbnRlbnQYBCABKAki",
            "LAoQQ3JlYXRCbG9nUmVxdWVzdBIYCgRibG9nGAEgASgLMgouYmxvZy5CbG9n",
            "Ii0KEUNyZWF0QmxvZ1Jlc3BvbnNlEhgKBGJsb2cYASABKAsyCi5ibG9nLkJs",
            "b2cyTgoLQmxvZ1NlcnZpY2USPwoKQ3JlYXRlQmxvZxIWLmJsb2cuQ3JlYXRC",
            "bG9nUmVxdWVzdBoXLmJsb2cuQ3JlYXRCbG9nUmVzcG9uc2UiAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Blog.Blog), global::Blog.Blog.Parser, new[]{ "Id", "AuthorId", "Title", "Content" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Blog.CreatBlogRequest), global::Blog.CreatBlogRequest.Parser, new[]{ "Blog" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Blog.CreatBlogResponse), global::Blog.CreatBlogResponse.Parser, new[]{ "Blog" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Blog : pb::IMessage<Blog> {
    private static readonly pb::MessageParser<Blog> _parser = new pb::MessageParser<Blog>(() => new Blog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Blog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Blog.BlogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Blog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Blog(Blog other) : this() {
      id_ = other.id_;
      authorId_ = other.authorId_;
      title_ = other.title_;
      content_ = other.content_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Blog Clone() {
      return new Blog(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "author_id" field.</summary>
    public const int AuthorIdFieldNumber = 2;
    private string authorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AuthorId {
      get { return authorId_; }
      set {
        authorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 3;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 4;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Blog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Blog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (AuthorId != other.AuthorId) return false;
      if (Title != other.Title) return false;
      if (Content != other.Content) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (AuthorId.Length != 0) hash ^= AuthorId.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (AuthorId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AuthorId);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Title);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (AuthorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthorId);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Blog other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.AuthorId.Length != 0) {
        AuthorId = other.AuthorId;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            AuthorId = input.ReadString();
            break;
          }
          case 26: {
            Title = input.ReadString();
            break;
          }
          case 34: {
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CreatBlogRequest : pb::IMessage<CreatBlogRequest> {
    private static readonly pb::MessageParser<CreatBlogRequest> _parser = new pb::MessageParser<CreatBlogRequest>(() => new CreatBlogRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreatBlogRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Blog.BlogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreatBlogRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreatBlogRequest(CreatBlogRequest other) : this() {
      blog_ = other.blog_ != null ? other.blog_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreatBlogRequest Clone() {
      return new CreatBlogRequest(this);
    }

    /// <summary>Field number for the "blog" field.</summary>
    public const int BlogFieldNumber = 1;
    private global::Blog.Blog blog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Blog.Blog Blog {
      get { return blog_; }
      set {
        blog_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreatBlogRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreatBlogRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Blog, other.Blog)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (blog_ != null) hash ^= Blog.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (blog_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Blog);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (blog_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Blog);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreatBlogRequest other) {
      if (other == null) {
        return;
      }
      if (other.blog_ != null) {
        if (blog_ == null) {
          Blog = new global::Blog.Blog();
        }
        Blog.MergeFrom(other.Blog);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (blog_ == null) {
              Blog = new global::Blog.Blog();
            }
            input.ReadMessage(Blog);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CreatBlogResponse : pb::IMessage<CreatBlogResponse> {
    private static readonly pb::MessageParser<CreatBlogResponse> _parser = new pb::MessageParser<CreatBlogResponse>(() => new CreatBlogResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreatBlogResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Blog.BlogReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreatBlogResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreatBlogResponse(CreatBlogResponse other) : this() {
      blog_ = other.blog_ != null ? other.blog_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreatBlogResponse Clone() {
      return new CreatBlogResponse(this);
    }

    /// <summary>Field number for the "blog" field.</summary>
    public const int BlogFieldNumber = 1;
    private global::Blog.Blog blog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Blog.Blog Blog {
      get { return blog_; }
      set {
        blog_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreatBlogResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreatBlogResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Blog, other.Blog)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (blog_ != null) hash ^= Blog.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (blog_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Blog);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (blog_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Blog);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreatBlogResponse other) {
      if (other == null) {
        return;
      }
      if (other.blog_ != null) {
        if (blog_ == null) {
          Blog = new global::Blog.Blog();
        }
        Blog.MergeFrom(other.Blog);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (blog_ == null) {
              Blog = new global::Blog.Blog();
            }
            input.ReadMessage(Blog);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code