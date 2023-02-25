global using System.Collections.Concurrent;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Diagnostics;
global using System.Linq.Expressions;
global using System.Net;
global using System.Net.Mail;
global using System.Reflection;
global using System.Security.Claims;
global using System.Security.Principal;
global using System.Text;

global using JetBrains.Annotations;

global using Microsoft.Extensions.Caching.Distributed;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.DependencyModel;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;

global using OSharp.Audits;
global using OSharp.Authorization;
global using OSharp.Authorization.Functions;
global using OSharp.Caching;
global using OSharp.Collections;
global using OSharp.Core.Builders;
global using OSharp.Core.Data;
global using OSharp.Core.Options;
global using OSharp.Core.Packs;
global using OSharp.Core.Systems;
global using OSharp.Data;
global using OSharp.Dependency;
global using OSharp.Entity;
global using OSharp.EventBuses;
global using OSharp.Exceptions;
global using OSharp.Extensions;
global using OSharp.Filter;
global using OSharp.Finders;
global using OSharp.Http;
global using OSharp.Identity;
global using OSharp.Identity.JwtBearer;
global using OSharp.Json;
global using OSharp.Linq;
global using OSharp.Logging;
global using OSharp.Mapping;
global using OSharp.Net;
global using OSharp.Properties;
global using OSharp.Reflection;
global using OSharp.Security;
global using OSharp.Threading;
global using OSharp.Timing;