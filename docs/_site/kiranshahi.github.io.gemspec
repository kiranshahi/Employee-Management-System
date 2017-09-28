# coding: utf-8

Gem::Specification.new do |spec|
  spec.name          = "kiranshahi.github.io"
  spec.version       = "0.1.0"
  spec.authors       = ["Kiran Shahi"]
  spec.email         = ["mail@kirans.com.np"]

  spec.summary       = %q{ Jekyll theme for my blog.}
  spec.description   = "This theme is developed for my blog under MIT license. You can download and change the content of this theme."
  spec.homepage      = "http://www.kirans.me"
  spec.license       = "MIT"

  spec.files         = `git ls-files -z`.split("\x0").select { |f| f.match(%r{^(assets|_layouts|_includes|_sass|LICENSE|README)}i) }

  spec.add_runtime_dependency "jekyll", "~> 3.4"
  spec.add_runtime_dependency "jekyll-seo-tag", "~> 2.1"


  spec.add_development_dependency "bundler", "~> 1.12"
  spec.add_development_dependency "rake", "~> 10.0"
end
