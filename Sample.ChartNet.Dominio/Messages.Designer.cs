﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.ChartNet.Dominio {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sample.ChartNet.Dominio.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nao pode adicionar entidade nula.
        /// </summary>
        internal static string info_NaoPodeAdicionarEntidadeNula {
            get {
                return ResourceManager.GetString("info_NaoPodeAdicionarEntidadeNula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nao pode remover entidade nula.
        /// </summary>
        internal static string info_NaoPodeRemoverEntidadeNula {
            get {
                return ResourceManager.GetString("info_NaoPodeRemoverEntidadeNula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário não encontrado para excluir.
        /// </summary>
        internal static string ValidationExcluirUsuarioNaoEncontrado {
            get {
                return ResourceManager.GetString("ValidationExcluirUsuarioNaoEncontrado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro Interno!.
        /// </summary>
        internal static string ValidationGenerico {
            get {
                return ResourceManager.GetString("ValidationGenerico", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo {0} deve ser preenchido!.
        /// </summary>
        internal static string ValidationGenericoCampoObrigatorio {
            get {
                return ResourceManager.GetString("ValidationGenericoCampoObrigatorio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tarefa alterada com sucesso!.
        /// </summary>
        internal static string ValidationTarefaAlteradaSucesso {
            get {
                return ResourceManager.GetString("ValidationTarefaAlteradaSucesso", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tarefa excluida com sucesso!.
        /// </summary>
        internal static string ValidationTarefaExcluidaSucesso {
            get {
                return ResourceManager.GetString("ValidationTarefaExcluidaSucesso", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tarefa Não encontrada!.
        /// </summary>
        internal static string ValidationTarefaNaoExiste {
            get {
                return ResourceManager.GetString("ValidationTarefaNaoExiste", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tarefa salva com sucesso!.
        /// </summary>
        internal static string ValidationTarefaSalvaSucesso {
            get {
                return ResourceManager.GetString("ValidationTarefaSalvaSucesso", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário excluida com sucesso!.
        /// </summary>
        internal static string ValidationUsuarioExcluidoSucesso {
            get {
                return ResourceManager.GetString("ValidationUsuarioExcluidoSucesso", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário sem premissão de acesso!.
        /// </summary>
        internal static string ValidationUsuarioLoginBloqueado {
            get {
                return ResourceManager.GetString("ValidationUsuarioLoginBloqueado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo login da entidade não pode ser nulo.
        /// </summary>
        internal static string ValidationUsuarioLoginNaoPodeSerNulo {
            get {
                return ResourceManager.GetString("ValidationUsuarioLoginNaoPodeSerNulo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo Perfil Acesso da entidade não pode ser nulo.
        /// </summary>
        internal static string ValidationUsuarioPerfilAcessoNaoPodeSerNulo {
            get {
                return ResourceManager.GetString("ValidationUsuarioPerfilAcessoNaoPodeSerNulo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário salvo com sucesso!.
        /// </summary>
        internal static string ValidationUsuarioSalvoSucesso {
            get {
                return ResourceManager.GetString("ValidationUsuarioSalvoSucesso", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O campo Senha da entidade não pode ser nulo.
        /// </summary>
        internal static string ValidationUsuarioSenhaNaoPodeSerNulo {
            get {
                return ResourceManager.GetString("ValidationUsuarioSenhaNaoPodeSerNulo", resourceCulture);
            }
        }
    }
}