<a name='assembly'></a>
# System.Common.Extensions

## Contents

- [CommonExtensions](#T-System-CommonExtensions 'System.CommonExtensions')
  - [DeHumanize(humanized,delimiter)](#M-System-CommonExtensions-DeHumanize-System-String,System-String- 'System.CommonExtensions.DeHumanize(System.String,System.String)')
  - [Distinct\`\`2(this,keySelector)](#M-System-CommonExtensions-Distinct``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}- 'System.CommonExtensions.Distinct``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})')
  - [Extend\`\`1(target,source)](#M-System-CommonExtensions-Extend``1-``0,``0- 'System.CommonExtensions.Extend``1(``0,``0)')
  - [ForAwait(task)](#M-System-CommonExtensions-ForAwait-System-Threading-Tasks-ValueTask@- 'System.CommonExtensions.ForAwait(System.Threading.Tasks.ValueTask@)')
  - [ForAwait(task)](#M-System-CommonExtensions-ForAwait-System-Threading-Tasks-Task- 'System.CommonExtensions.ForAwait(System.Threading.Tasks.Task)')
  - [ForAwait\`\`1(task)](#M-System-CommonExtensions-ForAwait``1-System-Threading-Tasks-ValueTask{``0}@- 'System.CommonExtensions.ForAwait``1(System.Threading.Tasks.ValueTask{``0}@)')
  - [ForAwait\`\`1(task)](#M-System-CommonExtensions-ForAwait``1-System-Threading-Tasks-Task{``0}- 'System.CommonExtensions.ForAwait``1(System.Threading.Tasks.Task{``0})')
  - [Format(value,arg0)](#M-System-CommonExtensions-Format-System-String,System-Object- 'System.CommonExtensions.Format(System.String,System.Object)')
  - [Format(value,args)](#M-System-CommonExtensions-Format-System-String,System-Object[]- 'System.CommonExtensions.Format(System.String,System.Object[])')
  - [GetDefault(type)](#M-System-CommonExtensions-GetDefault-System-Type- 'System.CommonExtensions.GetDefault(System.Type)')
  - [Humanize(value)](#M-System-CommonExtensions-Humanize-System-String- 'System.CommonExtensions.Humanize(System.String)')
  - [IfIs\`\`1(target,method)](#M-System-CommonExtensions-IfIs``1-System-Object,System-Action{``0}- 'System.CommonExtensions.IfIs``1(System.Object,System.Action{``0})')
  - [IfIs\`\`2(target,method)](#M-System-CommonExtensions-IfIs``2-System-Object,System-Func{``0,``1}- 'System.CommonExtensions.IfIs``2(System.Object,System.Func{``0,``1})')
  - [IfNotNull\`\`2(source,selector)](#M-System-CommonExtensions-IfNotNull``2-``0,System-Func{``0,``1}- 'System.CommonExtensions.IfNotNull``2(``0,System.Func{``0,``1})')
  - [In(value,stringValues)](#M-System-CommonExtensions-In-System-String,System-String[]- 'System.CommonExtensions.In(System.String,System.String[])')
  - [In\`\`1(source,list)](#M-System-CommonExtensions-In``1-``0,``0[]- 'System.CommonExtensions.In``1(``0,``0[])')
  - [IsDecimal(input)](#M-System-CommonExtensions-IsDecimal-System-String- 'System.CommonExtensions.IsDecimal(System.String)')
  - [IsDouble(input)](#M-System-CommonExtensions-IsDouble-System-String- 'System.CommonExtensions.IsDouble(System.String)')
  - [IsInt(input)](#M-System-CommonExtensions-IsInt-System-String- 'System.CommonExtensions.IsInt(System.String)')
  - [IsNotNull(input)](#M-System-CommonExtensions-IsNotNull-System-String- 'System.CommonExtensions.IsNotNull(System.String)')
  - [IsNull\`\`1(me)](#M-System-CommonExtensions-IsNull``1-``0- 'System.CommonExtensions.IsNull``1(``0)')
  - [IsNull\`\`1(me)](#M-System-CommonExtensions-IsNull``1-System-Nullable{``0}- 'System.CommonExtensions.IsNull``1(System.Nullable{``0})')
  - [IsSet(input)](#M-System-CommonExtensions-IsSet-System-String- 'System.CommonExtensions.IsSet(System.String)')
  - [Left(value,length)](#M-System-CommonExtensions-Left-System-String,System-Int32- 'System.CommonExtensions.Left(System.String,System.Int32)')
  - [Like(value,search)](#M-System-CommonExtensions-Like-System-String,System-String- 'System.CommonExtensions.Like(System.String,System.String)')
  - [ReferenceEquals(objA,objB)](#M-System-CommonExtensions-ReferenceEquals-System-Object,System-Object- 'System.CommonExtensions.ReferenceEquals(System.Object,System.Object)')
  - [Return\`\`2(value,evaluateFunc)](#M-System-CommonExtensions-Return``2-``0,System-Func{``0,``1}- 'System.CommonExtensions.Return``2(``0,System.Func{``0,``1})')
  - [Right(value,length)](#M-System-CommonExtensions-Right-System-String,System-Int32- 'System.CommonExtensions.Right(System.String,System.Int32)')
  - [SpinThread\`\`1(parms,action)](#M-System-CommonExtensions-SpinThread``1-``0,System-Action{``0}- 'System.CommonExtensions.SpinThread``1(``0,System.Action{``0})')
  - [SplitCamelCase(source)](#M-System-CommonExtensions-SplitCamelCase-System-String- 'System.CommonExtensions.SplitCamelCase(System.String)')
  - [ThrowIf\`\`1(val,predicate,exceptionFunc)](#M-System-CommonExtensions-ThrowIf``1-``0,System-Func{``0,System-Boolean},System-Func{System-Exception}- 'System.CommonExtensions.ThrowIf``1(``0,System.Func{``0,System.Boolean},System.Func{System.Exception})')
  - [ToDecimal(input)](#M-System-CommonExtensions-ToDecimal-System-String- 'System.CommonExtensions.ToDecimal(System.String)')
  - [ToDouble(input)](#M-System-CommonExtensions-ToDouble-System-String- 'System.CommonExtensions.ToDouble(System.String)')
  - [ToEnum\`\`1(value)](#M-System-CommonExtensions-ToEnum``1-System-String- 'System.CommonExtensions.ToEnum``1(System.String)')
  - [ToInt(input)](#M-System-CommonExtensions-ToInt-System-String- 'System.CommonExtensions.ToInt(System.String)')
  - [ToLogString(ex,additionalMessage)](#M-System-CommonExtensions-ToLogString-System-Exception,System-String- 'System.CommonExtensions.ToLogString(System.Exception,System.String)')
  - [ToNull(_)](#M-System-CommonExtensions-ToNull-System-Object- 'System.CommonExtensions.ToNull(System.Object)')
  - [ToUrlSlug(value)](#M-System-CommonExtensions-ToUrlSlug-System-String- 'System.CommonExtensions.ToUrlSlug(System.String)')

<a name='T-System-CommonExtensions'></a>
## CommonExtensions `type`

##### Namespace

System

##### Summary

Defines the [CommonExtensions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.CommonExtensions 'System.CommonExtensions')

<a name='M-System-CommonExtensions-DeHumanize-System-String,System-String-'></a>
### DeHumanize(humanized,delimiter) `method`

##### Summary

Make Readable string Dirty

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| humanized | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | humanized string[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | delimiter [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-Distinct``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}-'></a>
### Distinct\`\`2(this,keySelector) `method`

##### Summary

Provides a Distinct method that takes a key selector lambda as parameter.
The .net framework only provides a Distinct method that takes an instance
of an implementation of IEqualityComparer where the standard parameter less
Distinct that uses the default equality comparer doesn't suffice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | IEnumerable. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | key selector. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |
| TKey | The type of the key. |

<a name='M-System-CommonExtensions-Extend``1-``0,``0-'></a>
### Extend\`\`1(target,source) `method`

##### Summary

An extension function to work like the extend method of javascript. It takes the object and merge with oder, but only if the property of the other object has value.

##### Returns

The [](#!-T 'T')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [\`\`0](#T-``0 '``0') | The target[](#!-T 'T') |
| source | [\`\`0](#T-``0 '``0') | The source[](#!-T 'T') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-ForAwait-System-Threading-Tasks-ValueTask@-'></a>
### ForAwait(task) `method`

##### Summary

The ForAwait

##### Returns

The [ConfiguredValueTaskAwaitable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable 'System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| task | [System.Threading.Tasks.ValueTask@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask@ 'System.Threading.Tasks.ValueTask@') | The task[ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') |

<a name='M-System-CommonExtensions-ForAwait-System-Threading-Tasks-Task-'></a>
### ForAwait(task) `method`

##### Summary

The ForAwait

##### Returns

The [ConfiguredTaskAwaitable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.CompilerServices.ConfiguredTaskAwaitable 'System.Runtime.CompilerServices.ConfiguredTaskAwaitable')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| task | [System.Threading.Tasks.Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') | The task[Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') |

<a name='M-System-CommonExtensions-ForAwait``1-System-Threading-Tasks-ValueTask{``0}@-'></a>
### ForAwait\`\`1(task) `method`

##### Summary

The ForAwait

##### Returns

The [ConfiguredValueTaskAwaitable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1 'System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| task | [System.Threading.Tasks.ValueTask{\`\`0}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask{``0}@') | The task[ValueTask\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask`1 'System.Threading.Tasks.ValueTask`1') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-ForAwait``1-System-Threading-Tasks-Task{``0}-'></a>
### ForAwait\`\`1(task) `method`

##### Summary

The ForAwait

##### Returns

The [ConfiguredTaskAwaitable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1 'System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| task | [System.Threading.Tasks.Task{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{``0}') | The task[Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-Format-System-String,System-Object-'></a>
### Format(value,arg0) `method`

##### Summary

Replaces the format item in a specified System.String with the text equivalent
 of the value of a specified System.Object instance.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string |
| arg0 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An System.Object to format |

<a name='M-System-CommonExtensions-Format-System-String,System-Object[]-'></a>
### Format(value,args) `method`

##### Summary

Replaces the format item in a specified System.String with the text equivalent
 of the value of a specified System.Object instance.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | An System.Object array containing zero or more objects to format. |

<a name='M-System-CommonExtensions-GetDefault-System-Type-'></a>
### GetDefault(type) `method`

##### Summary

The GetDefault

##### Returns

The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type[Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |

<a name='M-System-CommonExtensions-Humanize-System-String-'></a>
### Humanize(value) `method`

##### Summary

Human Readable string

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-IfIs``1-System-Object,System-Action{``0}-'></a>
### IfIs\`\`1(target,method) `method`

##### Summary

allows an action to be taken on an object if it is castable as the given type, with no return value.
if the target does not match the type, does nothing

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The target[Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |
| method | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The method[Action\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action`1 'System.Action`1') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-IfIs``2-System-Object,System-Func{``0,``1}-'></a>
### IfIs\`\`2(target,method) `method`

##### Summary

allows an action to be taken on an object if it is castable as the given type, with a return value.
if the target does not match the type, returns default(T)

##### Returns

The [](#!-TResult 'TResult')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The target[Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |
| method | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The method[Func\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func`2 'System.Func`2') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |
| TResult |  |

<a name='M-System-CommonExtensions-IfNotNull``2-``0,System-Func{``0,``1}-'></a>
### IfNotNull\`\`2(source,selector) `method`

##### Summary

Returns a selected value when the source is not null; null otherwise.

##### Returns

The selected value when source is not null; null otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | The source[](#!-T 'T') |
| selector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The selector[Func\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func`2 'System.Func`2') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |
| TInner |  |

<a name='M-System-CommonExtensions-In-System-String,System-String[]-'></a>
### In(value,stringValues) `method`

##### Summary

Checks string object's value to array of string values

##### Returns

Return true if any string value matches

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |
| stringValues | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of string values to compare |

<a name='M-System-CommonExtensions-In``1-``0,``0[]-'></a>
### In\`\`1(source,list) `method`

##### Summary

Allows you to compare a value to a list of values analogous to the 'In' statement in sql.
This makes for a very friendly syntax that is (IMHO) superior to a list of 'or' clauses. 
Instead of : if (s=="John" || s=="Peter" or s=="Paul") one can write if (s.In("John","Paul","Peter"))

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | The source[](#!-T 'T') |
| list | [\`\`0[]](#T-``0[] '``0[]') | The list[](#!-T[] 'T[]') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-IsDecimal-System-String-'></a>
### IsDecimal(input) `method`

##### Summary

Check string  IsDecimal

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-IsDouble-System-String-'></a>
### IsDouble(input) `method`

##### Summary

Check string IsDouble

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-IsInt-System-String-'></a>
### IsInt(input) `method`

##### Summary

Check string IsInt

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-IsNotNull-System-String-'></a>
### IsNotNull(input) `method`

##### Summary

Check if Input string is not null or whitespace

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-IsNull``1-``0-'></a>
### IsNull\`\`1(me) `method`

##### Summary

Check  IsNull

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| me | [\`\`0](#T-``0 '``0') | The me[](#!-T 'T') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-IsNull``1-System-Nullable{``0}-'></a>
### IsNull\`\`1(me) `method`

##### Summary

Check IsNull

##### Returns

True or False [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| me | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | Struct need to check is null[](#!-T 'T') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Where T is struct |

<a name='M-System-CommonExtensions-IsSet-System-String-'></a>
### IsSet(input) `method`

##### Summary

Check if string is null or empty

##### Returns

True or False [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-Left-System-String,System-Int32-'></a>
### Left(value,length) `method`

##### Summary

Returns characters from left of specified length

##### Returns

Returns string from left

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String value |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Max number of characters to return |

<a name='M-System-CommonExtensions-Like-System-String,System-String-'></a>
### Like(value,search) `method`

##### Summary

An C# extension method based on "LIKE" operator of T-SQL.

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The search[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-ReferenceEquals-System-Object,System-Object-'></a>
### ReferenceEquals(objA,objB) `method`

##### Summary

This extension method represents shorthand version of ReferenceEquals method.

##### Returns

The [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objA | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The objA[Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |
| objB | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The objB[Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |

<a name='M-System-CommonExtensions-Return``2-``0,System-Func{``0,``1}-'></a>
### Return\`\`2(value,evaluateFunc) `method`

##### Summary

Returns a value based on an provided value and evaluation function

##### Returns

The [](#!-TOut 'TOut')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value[](#!-TIn 'TIn') |
| evaluateFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The evaluateFunc[Func\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func`2 'System.Func`2') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn |  |
| TOut |  |

<a name='M-System-CommonExtensions-Right-System-String,System-Int32-'></a>
### Right(value,length) `method`

##### Summary

Returns characters from right of specified length

##### Returns

Returns string from right

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String value |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Max number of charaters to return |

<a name='M-System-CommonExtensions-SpinThread``1-``0,System-Action{``0}-'></a>
### SpinThread\`\`1(parms,action) `method`

##### Summary

Spins up and executes the action within a thread. Basically fire and forget. 
Real big question here. Does anybody see any issues with thread management? 
I would like to update this with any code necessary to manage thread cleanup if necessary. 
I realize that this has the ability to create unsafe thread referencing if not written such 
that the contents of the action are exclusive to the scope of the action, but that is outside the purview of this extension

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parms | [\`\`0](#T-``0 '``0') | The parms[](#!-T 'T') |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action[Action\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action`1 'System.Action`1') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-SplitCamelCase-System-String-'></a>
### SplitCamelCase(source) `method`

##### Summary

Split Camel Case string to space delimited

##### Returns

spited string array

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The source[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-ThrowIf``1-``0,System-Func{``0,System-Boolean},System-Func{System-Exception}-'></a>
### ThrowIf\`\`1(val,predicate,exceptionFunc) `method`

##### Summary

Throw's a given exception is a given predicate is True

##### Returns

T object to throw exception [](#!-T 'T')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [\`\`0](#T-``0 '``0') | The val[](#!-T 'T') |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | The predicate[](#!-Func<T, bool> 'Func<T, bool>') |
| exceptionFunc | [System.Func{System.Exception}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception}') | The exceptionFunc[Func\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func`1 'System.Func`1') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-System-CommonExtensions-ToDecimal-System-String-'></a>
### ToDecimal(input) `method`

##### Summary

Converts string to  ToDecimal

##### Returns

The [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-ToDouble-System-String-'></a>
### ToDouble(input) `method`

##### Summary

Converts string to  ToDouble

##### Returns

The [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-ToEnum``1-System-String-'></a>
### ToEnum\`\`1(value) `method`

##### Summary

Converts string to enum object

##### Returns

Returns enum object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String value to convert |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of enum |

<a name='M-System-CommonExtensions-ToInt-System-String-'></a>
### ToInt(input) `method`

##### Summary

The ToInt

##### Returns

The [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-System-CommonExtensions-ToLogString-System-Exception,System-String-'></a>
### ToLogString(ex,additionalMessage) `method`

##### Summary

Creates a log-string from the Exception.

The result includes the stacktrace, innerexception et cetera, separated by .

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception to create the string from. |
| additionalMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Additional message to place at the top of the string, maybe be empty or null. |

<a name='M-System-CommonExtensions-ToNull-System-Object-'></a>
### ToNull(_) `method`

##### Summary

Make object Null

##### Returns

The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | _[Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |

<a name='M-System-CommonExtensions-ToUrlSlug-System-String-'></a>
### ToUrlSlug(value) `method`

##### Summary

Make  Url Slug

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |
